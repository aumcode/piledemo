﻿using System;
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
     private KeyedMonitor<long> m_Locker = new KeyedMonitor<long>();

     private ICacheTable<long> TBL_USER { get { return m_Cache.GetOrCreateTable<long>("user"); } }
     private ICacheTable<long> TBL_POST { get { return m_Cache.GetOrCreateTable<long>("post"); } }

     private ICacheTable<long> TBL_USERPOST { get { return m_Cache.GetOrCreateTable<long>("user-post"); } }

    #endregion


    public long UserCount { get { return TBL_USER.Count; } }
    public long PostCount { get { return TBL_POST.Count; } }

    public bool PutUser(User user)
    {
      return m_Locker.Synchronized(user.ID, () => TBL_USER.Put(user.ID, user) == PutResult.Inserted);
    }

    public bool RemoveUser(long userID)
    {
      return m_Locker.Synchronized(userID, () =>
      {
        var deleted = TBL_USER.Remove(userID);
        if (!deleted) return false;

        var posts = TBL_USERPOST.Get(userID) as long[];
        if (posts == null) return true;
        TBL_USERPOST.Remove(userID); //todo  Rewrite with table.RemoveReturning()

        foreach (var postID in posts)
          TBL_POST.Remove(postID);

        return true;
      });
    }



    public bool PutPost(Post post)
    {
      return m_Locker.Synchronized(post.UserID, () =>
      {
        TBL_POST.Put(post.PostID, post);

        var uposts = TBL_USERPOST.Get(post.UserID) as List<long>;
        if (uposts == null) uposts = new List<long>();
        if (uposts.Any(id => id == post.PostID)) return false;

        uposts.Add(post.PostID);
        TBL_USERPOST.Put(post.UserID, uposts);
        return true;
      });
    }

    public bool RemovePost(long postID)
    {
      var post = TBL_POST.Get(postID) as Post;
      if (post == null) return false;
      return m_Locker.Synchronized(post.UserID, () =>
      {
        var result = TBL_POST.Remove(postID);
        TBL_USERPOST.Remove(post.UserID);
        return result;
      });
    }

    public bool VotePost(long postID, int count)
    {
      throw new NotImplementedException();
    }


    public IEnumerable<KeyValuePair<User, Post>> GetMentionedUserPosts(long userID)
    {
      throw new NotImplementedException();
      //var posts = TBL_USERPOST.Get(userID) as List<long>;
      //if (posts == null) return Enumerable.Empty<KeyValuePair<User, Post>>();
      //return posts.Select(pid => new KeyValuePair<User, Post>());
    }

    public IEnumerable<Post> GetUserPosts(long userID, out User user)
    {
      user = TBL_USER.Get(userID) as User;
      if (user == null) return Enumerable.Empty<Post>();
      return m_Locker.Synchronized(userID, () =>
      {
        var posts = TBL_USERPOST.Get(userID) as List<long>;
        if (posts == null) return Enumerable.Empty<Post>();
        return posts.Select(pid => TBL_POST.Get(pid) as Post).Where( p => p!=null);
      });
    }


    #region .pvt

    #endregion

  }
}
