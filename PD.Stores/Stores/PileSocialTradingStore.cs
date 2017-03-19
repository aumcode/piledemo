using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.ApplicationModel.Pile;
using NFX.DataAccess.Distributed;
using PD.Contracts.SocialTrading;

namespace PD.Stores
{
  public class PileSocialTradingStore : DisposableObject, IUserStore
  {

    public PileSocialTradingStore()
    {
      m_Data = new Dictionary<GDID, PilePointer>[0xff];
      for (var i = 0; i < m_Data.Length; i++)
        m_Data[i] = new Dictionary<GDID, PilePointer>();

      m_Pile = new DefaultPile();
      m_Pile.Configure(null);
      m_Pile.Start();
    }

    protected override void Destructor()
    {
      base.Destructor();
      DisposeAndNull(ref m_Pile);
    }

    private Dictionary<GDID, PilePointer> getBucket(GDID id)
    {
      return m_Data[id.Counter & 0xff];
    }

    private DefaultPile m_Pile;
    private Dictionary<GDID, PilePointer>[] m_Data;

    public long Count { get { return m_Data.Sum(d => { lock(d) return d.Count; }); }}

    public User AcceptTrade(GDID gUser, User.Trade trade)
    {
      User result;
      var d = getBucket(gUser);
      lock (d)
      {
        PilePointer pp;
        if (!d.TryGetValue(gUser, out pp)) return null;
        result = (User) m_Pile.Get(pp);
        result.AddTrade(trade);
        m_Pile.Delete(pp);
        d[gUser] = m_Pile.Put(result);
      }

      return result;
    }

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

  }
}
