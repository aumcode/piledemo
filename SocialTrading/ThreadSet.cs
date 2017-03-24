using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NFX;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class ThreadSet : DisposableObject
  {

    public ThreadSet(IUserStore store)
    {
      m_Store = store;
      m_Log = new ConcurrentQueue<string>();
      m_List = new List<Thread>();
    }

    private IUserStore m_Store;

    private int m_Reads;
    private int m_Writes;
    private int m_Deletes;

    private ConcurrentQueue<string> m_Log;


    private List<Thread> m_List;

    private int Count { get { return m_List.Count; } }


    public void Set(int threads, int reads, int writes, int deletes)
    {
      m_Reads = reads;
      m_Writes = writes;
      m_Deletes = deletes;

      lock(m_List)
      {
        while (m_List.Count > threads) m_List.RemoveAt(0);
        while (m_List.Count< threads)
        {
          var t = new Thread(threadSpin);
          t.IsBackground = true;
          t.Start(m_List.Count);
          m_List.Add(t);
        }
      }
    }



    private void threadSpin(object thread)
    {
      var num = (int)thread;
      var missing = new List<GDID>();
      while(!DisposeStarted)
      {
        lock(m_List)
        {
          if (m_List.Count < num) return;
        }

        try
        {
          var count = m_Store.Count;// .Get(gUser);
          for (var i = 0; i < m_Reads; i++)
          {
            var gExisting = new GDID(0, (ulong)(count * ExternalRandomGenerator.Instance.NextScaledRandomDouble(0, 1.0d)));

            var existing = m_Store.Get(gExisting);
            if (existing == null)
              missing.Add(gExisting);
          }

          for (var i = 0; i < m_Deletes; i++)
          {
            var gExisting = new GDID(0, (ulong)(count * ExternalRandomGenerator.Instance.NextScaledRandomDouble(0, 1.0d)));

            var deleted = m_Store.Remove(gExisting);
            if (deleted)
              missing.Add(gExisting);
          }


          for (var i = 0; i < m_Writes; i++)
          {
            User user;// = new User(id) { };
            if (missing.Count > 0)
            {
              user = makeUser(missing[missing.Count - 1]);
              missing.RemoveAt(missing.Count - 1);
            }
            else
            {
              count++;
              var id = new GDID(0, (ulong)count);
              user = makeUser(id);
            }

            m_Store.Put(user);
          }
        }
        catch(Exception error)
        {
          m_Log.Enqueue(error.ToMessageWithType());
        }

      }
    }

    private User makeUser(GDID id)
    {
      return new User(id)
      {
         Name = "Abcds"+id,
         DOB = new DateTime(1980, 1, 1),
         SocialMsg = new NFX.Collections.StringMap { { "a", "aaa"}, { "b", "bbb"} },
         BuyerScore = 34,
         SellerScore = 473,
         GVendor = id.Counter%3==0 ? null : (GDID?)id,
         IsVendor = true,
         ReturnApproved = false
      };
    }


  }
}
