using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.DataAccess.Distributed;

namespace PD.SocialTrading
{
  public class CLRSocialTradingStore : IUserStore
  {

    public CLRSocialTradingStore()
    {
      m_Data = new Dictionary<GDID, User>[0xff];
      for (var i = 0; i < m_Data.Length; i++)
        m_Data[i] = new Dictionary<GDID, User>();
    }

    private Dictionary<GDID, User> getBucket(GDID id)
    {
      return m_Data[id.Counter & 0xff];
    }

    private Dictionary<GDID, User>[] m_Data;

    public long Count { get { return m_Data.Sum(d => { lock(d) return d.Count; }); }}

    public User AcceptTrade(GDID gUser, User.Trade trade)
    {
      User result;
      var d = getBucket(gUser);
      lock (d)
      {
        if (!d.TryGetValue(gUser, out result)) return null;
        result.AddTrade(trade);
      }

      return result;
    }

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

  }
}
