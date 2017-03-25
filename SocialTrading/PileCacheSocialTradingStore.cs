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
  public class PileCacheSocialTradingStore : DisposableObject, IUserStore
  {

    public PileCacheSocialTradingStore(IPileImplementation pile)
    {
      m_Pile = pile;
      m_Cache = new LocalCache(m_Pile, null, null);
      m_Cache.Configure(null);
      m_Cache.Start();
    }

    protected override void Destructor()
    {
      DisposeAndNull(ref m_Cache);
      base.Destructor();
    }

    private long m_IDSeed;

    public long IDSeed { get { return m_IDSeed; } }

    public GDID MakeID()
    {
      return new GDID(0, (ulong)Interlocked.Increment(ref m_IDSeed));
    }

    private IPileImplementation m_Pile;
    private LocalCache m_Cache;

    public long Count { get { return m_Cache.Count;  }}


    public User Get(GDID gUser)
    {
      return (User)getTable(gUser).Get(gUser);
    }

    public bool Put(User user)
    {
      return getTable(user.ID).Put(user.ID, user, maxAgeSec: int.MaxValue) == PutResult.Inserted;
    }

    public bool Remove(GDID gUser)
    {
      return getTable(gUser).Remove(gUser);
    }

    public void Purge()
    {
      m_Cache.PurgeAll();
      m_IDSeed = 0;
    }

    private ICacheTable<GDID> getTable(GDID gUser)
    {
      return m_Cache.GetOrCreateTable<GDID>((gUser.Counter & 0x0fff).ToString());
    }

  }
}
