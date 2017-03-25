using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using NFX;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class CLRSocialTradingStore : DisposableObject, IUserStore
  {

    public CLRSocialTradingStore()
    {
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

    private Dictionary<GDID, User> getBucket(GDID id)
    {
      return m_Data[id.Counter & 0xff];
    }

    private Dictionary<GDID, User>[] m_Data;

    public long Count { get { return m_Data.Sum(d => { lock(d) return (long)d.Count; }); }}

    public User Get(GDID gUser)
    {
      User result;
      var d = getBucket(gUser);
      lock(d)
        if (d.TryGetValue(gUser, out result)) return result;
      return null;
    }

    public bool Put(User user)
    {
      var d = getBucket(user.ID);
      lock (d)
        if (d.ContainsKey(user.ID))
        {
          d[user.ID] = user;
          return false;
        }
        else
        {
          d.Add(user.ID, user);
          return true;
        }
    }

    public bool Remove(GDID gUser)
    {
      var d = getBucket(gUser);
      lock (d)
        return d.Remove(gUser);
    }

    public void Purge()
    {
      var data = new Dictionary<GDID, User>[0xff+1];
      for (var i = 0; i < data.Length; i++)
        data[i] = new Dictionary<GDID, User>(1024 * 1024);

      m_Data = data;
      m_IDSeed = 0;
    }

  }
}
