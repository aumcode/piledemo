using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.ApplicationModel.Pile;

namespace UserGraph
{
  public class PileUserGraph : DisposableObject, IUserGraph
  {
    #region .ctor/.dctor
    public PileUserGraph(IPileImplementation pile)
    {
      m_Pile = pile;
      m_Cache = new LocalCache();
      m_Cache.Pile = pile;
      m_Cache.DefaultTableOptions.CollisionMode = CollisionMode.Durable;//keep all entries (slower, uses chaining)
      m_Cache.DefaultTableOptions.DefaultMaxAgeSec = 0;//never expire items
      m_Cache.Start();
    }

    protected override void Destructor()
    {
      DisposeAndNull(ref m_Cache);//dispose would stop the cache bg workers and free resources
      base.Destructor();
    }
    #endregion

    #region Fields

     private IPileImplementation m_Pile;
     private LocalCache m_Cache;

     private ICacheTable<long> TBL_USER { get { return m_Cache.GetOrCreateTable<long>("user"); } }
     private ICacheTable<long> TBL_POST { get { return m_Cache.GetOrCreateTable<long>("post"); } }

     private ICacheTable<long> TBL_USERPOST { get { return m_Cache.GetOrCreateTable<long>("user-post"); } }

    #endregion


    public long UserCount { get { return TBL_USER.Count; } }
    public long PostCount { get { return TBL_POST.Count; } }

    public bool PutUser(User user)
    {
      return TBL_USER.Put(user.ID, user) == PutResult.Inserted;
    }

    public bool RemoveUser(long userID)
    {
      var deleted = TBL_USER.Remove(userID);
      if (!deleted) return false;

      var posts = TBL_USERPOST.Get(userID) as long[];
      if (posts == null) return true;
      TBL_USERPOST.Remove(userID); //todo  Rewrite with table.RemoveReturning()

      foreach (var postID in posts)
        TBL_POST.Remove(postID);

      return true;
    }



    public bool PutPost(Post post)
    {
      throw new NotImplementedException();
    }

    public bool RemovePost(long postID)
    {
      throw new NotImplementedException();
    }

    public bool VotePost(long postID, int count)
    {
      throw new NotImplementedException();
    }


    public IEnumerable<KeyValuePair<User, Post>> GetMentionedUserPosts(long userID)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Post> GetUserPosts(long userID, out User user)
    {
      throw new NotImplementedException();
    }


    #region .pvt

    #endregion

  }
}
