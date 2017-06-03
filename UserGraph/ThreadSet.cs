using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NFX;
using NFX.Parsing;

namespace UserGraph
{
  public class ThreadSet : DisposableObject
  {

    public ThreadSet(IUserGraph graph)
    {
      m_Graph = graph;
      m_Log = new ConcurrentQueue<string>();
      m_List = new List<Thread>();
    }

    protected override void Destructor()
    {
      base.Destructor();
      foreach (var t in m_List) t.Join();
    }

    private IUserGraph m_Graph;

    private int m_UserCount;
    private int m_PostReads;
    private int m_PostWrites;
    private int m_PostVotes;
    private int m_PostDeletes;

    private ConcurrentQueue<string> m_Log;
    private List<Thread> m_List;


    private long m_stat_ReadHit;
    private long m_stat_ReadMiss;
    private long m_stat_Write;
    private long m_stat_DeleteHit;
    private long m_stat_DeleteMiss;


    public int Count { get { return m_List.Count; } }

    public string TryGetLog()
    {
      string result;
      if (!m_Log.TryDequeue(out result)) return null;
      return result;
    }

    public void Log(string message)
    {
      if (m_Log.Count > 1000) return;
      m_Log.Enqueue(message);
    }


    public void Stats(out long rHit,
                      out long rMiss,
                      out long dHit,
                      out long dMiss,
                      out long write
                      )
    {
      rHit  = Interlocked.Exchange(ref m_stat_ReadHit, 0);
      rMiss = Interlocked.Exchange(ref m_stat_ReadMiss, 0);
      dHit  = Interlocked.Exchange(ref m_stat_DeleteHit, 0);
      dMiss = Interlocked.Exchange(ref m_stat_DeleteMiss, 0);
      write = Interlocked.Exchange(ref m_stat_Write, 0);
    }


    public void Set(int threads, int userCount, int postR, int postW, int postV, int postD)
    {
      m_UserCount   = userCount;
      m_PostReads   = postR;
      m_PostWrites  = postW;
      m_PostVotes   = postV;
      m_PostDeletes = postD;

      lock (m_List)
      {
        while (m_List.Count > threads) m_List.RemoveAt(0);
        while (m_List.Count < threads)
        {
          var t = new Thread(threadSpin);
          t.IsBackground = true;
          m_List.Add(t);
          t.Start(m_List.Count);
        }
      }
    }



    private void threadSpin(object thread)
    {
      Log("{0} {1} Thread Started".Args(m_Graph.GetType().Name, App.TimeSource.Now));
      var threadNumber = (int)thread;
      var cnt = 0;
      while(!DisposeStarted)
      {
        if (cnt > 200)
        {
          cnt = 0;
          lock (m_List)
          {
            if (m_List.Count < threadNumber) break;
          }
        }
        else cnt++;

        //var zzzuid = m_Graph.NewUserID();
        //var zzzuser = makeUser(zzzuid);
        //m_Graph.PutUser(zzzuser);

        //continue;



        try
        {
          var existingUserCount = m_Graph.UserCount;
          var existingPostCount = m_Graph.PostCount;

          if (existingUserCount < m_UserCount)//create new users
          {
            var uid = m_Graph.NewUserID();
            var user = makeUser(uid);
            m_Graph.PutUser(user);
          }
          else if (existingUserCount > m_UserCount)//delete
          {
            var delete = existingUserCount - m_UserCount;
            var toDelete = delete - ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)(delete * 0.2d));
            for (var i = 0; i < toDelete; i++)//delete users
            {
              var uid = getRandomUserID();
              m_Graph.RemoveUser(uid);
            }
          }


          if (m_PostWrites>0)
          {
            var toWrite = m_PostWrites - ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)(m_PostWrites * 0.25d));
            for (var i = 0; i < toWrite; i++)//write posts
            {
              var uid = getRandomUserID();
              var pid = m_Graph.NewPostID();
              var post = makePost(uid, pid, existingUserCount);
              m_Graph.PutPost(post);
            }

          }

          if (m_PostDeletes > 0)
          {
            var toDelete = m_PostDeletes - ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)(m_PostDeletes * 0.5d));
            for (var i = 0; i < toDelete; i++)//delete posts
            {
              var pid = ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)existingPostCount);
              m_Graph.RemovePost(pid);
            }
          }

          if (m_PostVotes > 0)
          {
            var toVote = m_PostVotes - ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)(m_PostVotes * 0.5d));
            for (var i = 0; i < toVote; i++)//delete posts
            {
              var pid = getRandomPostID();
              m_Graph.VotePost(pid, ExternalRandomGenerator.Instance.NextScaledRandomInteger(-5, +5));
            }
          }

          if (m_PostReads > 0)
          {
            var toRead = m_PostReads - ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)(m_PostReads * 0.5d));
            for (var i = 0; i < toRead; i++)//delete posts
            {
              var uid = getRandomUserID();
              User user;
              m_Graph.GetUserPosts(uid, out user);
            }
          }


          //randomize
          //Thread.SpinWait(ExternalRandomGenerator.Instance.NextScaledRandomInteger(10, 1000));
        //  if (ExternalRandomGenerator.Instance.NextRandomInteger>1500000000)
       //     Thread.Sleep(ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, 50));
        }
        catch(Exception error)
        {
          Log("{0} {1} Thread Exception: {2}".Args(m_Graph.GetType().Name, App.TimeSource.Now, error.ToMessageWithType()));
        }
      }
      Log("{0} {1} Thread Finished".Args(m_Graph.GetType().Name, App.TimeSource.Now));
    }


    private long getRandomUserID()
    {
      return (long)(ExternalRandomGenerator.Instance.NextRandomDouble * m_Graph.UserIDRange);
    }

    private long getRandomPostID()
    {
      return (long)(ExternalRandomGenerator.Instance.NextRandomDouble * m_Graph.PostIDRange);
    }


    private User makeUser(long id)
    {
      var chance = ExternalRandomGenerator.Instance.NextRandomInteger;

      var now = App.TimeSource.UTCNow;
      var user = new User
      {
        ID = id,
        Name = "User Joe "+id.ToString(),
        RegistrationDate = now,
        LastLoginDate = now,
        EMail = id.ToString()+"mydomain.com",
        CanVote = (chance & 1) == 0

      };
      if (chance > 500000000)
        user.Location = NaturalTextGenerator.GenerateCityName();

      return user;
    }

    private Post makePost(long uid, long pid, long existingUserCout)
    {
      var chance = ExternalRandomGenerator.Instance.NextRandomInteger;

      var now = App.TimeSource.UTCNow;
      var post = new Post
      {
        PostID = pid,
        UserID = uid,
        CreateDate = now,
        Title = "aaaaaaaaaaaaaaaaaaaaa",//NaturalTextGenerator.Generate(128),
        Text = "werwqruwqoeruowpifuopiusodiufsaoufoisuafuposaufoisuf"//NaturalTextGenerator.Generate( ExternalRandomGenerator.Instance.NextScaledRandomInteger(12, 256) ),
      };
      if (chance > 1500000000)
      {
        var mcnt = chance % 6;
        post.MentionUserIDs = new long[mcnt];
        for (var i = 0; i < mcnt; i++)
          post.MentionUserIDs[i] = ExternalRandomGenerator.Instance.NextScaledRandomInteger(0, (int)existingUserCout);
      }

      return post;
    }


  }
}
