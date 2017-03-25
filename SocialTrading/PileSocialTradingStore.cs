using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using NFX;
using NFX.ApplicationModel.Pile;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class PileSocialTradingStore : DisposableObject, IUserStore
  {

    public PileSocialTradingStore(IPile pile)
    {
      m_Pile = pile;
      Purge();
    }

    protected override void Destructor()
    {
      base.Destructor();
    }

    private long m_IDSeed;

    public long IDSeed { get { return m_IDSeed; } }

    public GDID MakeID()
    {
      return new GDID(0, (ulong)Interlocked.Increment(ref m_IDSeed));
    }

    private Dictionary<GDID, PilePointer> getBucket(GDID id)
    {
      return m_Data[id.Counter & 0xff];
    }

    private IPile m_Pile;
    private Dictionary<GDID, PilePointer>[] m_Data;

    public long Count { get { return m_Data.Sum(d => { lock(d) return (long)d.Count; }); }}


    public User Get(GDID gUser)
    {
      var d = getBucket(gUser);
      lock (d)
      {
        PilePointer pp;
        if (d.TryGetValue(gUser, out pp))
          return (User)m_Pile.Get(pp);
      }

      return null;
    }

    public bool Put(User user)
    {
      var d = getBucket(user.ID);
      lock (d)
      {
        PilePointer pp;
        if (d.TryGetValue(user.ID, out pp))
        {
          m_Pile.Delete(pp);
          pp = m_Pile.Put(user);
          d[user.ID] = pp;
          return false;
        }
        else
        {
          pp = m_Pile.Put(user);
          d.Add(user.ID, pp);
          return true;
        }
      }
    }

    public bool Remove(GDID gUser)
    {
      var d = getBucket(gUser);
      lock (d)
      {
        PilePointer pp;
        if (d.TryGetValue(gUser, out pp))
        {
          m_Pile.Delete(pp);
          d.Remove(gUser);
          return true;
        }
      }
      return false;
    }

    public void Purge()
    {
      var data =  new Dictionary<GDID, PilePointer>[0xff + 1];
      for (var i = 0; i < data.Length; i++)
        data[i] = new Dictionary<GDID, PilePointer>();

      m_Data = data;

      m_Pile.Purge();
      m_IDSeed = 0;
    }

  }
}
