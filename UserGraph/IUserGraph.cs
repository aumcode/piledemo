using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.DataAccess.Distributed;

namespace UserGraph
{

  public enum UserSex { Unspecified=0, Male, Female }

  public class User
  {
    public User() { }

    public long     ID               { get; set; }
    public string   Name             { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLoginDate    { get; set; }
    public string   EMail            { get; set; }
    public UserSex  Sex              { get; set; }
    public string   Location         { get; set; }
  }

  public struct FriendConnection
  {
    public long FriendID { get; set; }
    public bool IsPublic { get; set; }
    public float Bond { get; set; }
    public DateTime CreateDate { get; set; }
  }

  public class Post
  {
    public long PostID { get; set; }
    public long UserID { get; set; }
    public DateTime CreateDate { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public long Up   { get; set; }
    public long Down { get; set; }
  }



  public class Circles
  {
    public class Connection
    {
      public User  User     { get; set; }
      public int   Rank     { get; set; }
      public bool  IsPublic { get; set; }
      public float Bond     { get; set; }
    }

    public User User { get; set; }
    public Connection[] Friends { get; set; }
  }


  public interface IUserGraph
  {
    /// <summary>
    /// Returns the number of users
    /// </summary>
    long UserCount { get; }

    /// <summary>
    /// Returns the number of user connections
    /// </summary>
    long ConnectionCount { get; }


    /// <summary>
    /// Adds user to graph, if exists with such id, replaces.
    /// True if added new
    /// </summary>
    bool Add(User user);

    /// <summary>
    /// Removes user returning true if found and removed, false otherwise
    /// </summary>
    bool Remove(long id);

    /// <summary>
    /// Adds user friend returning true, or false if exists
    /// </summary>
    bool AddFriend(long user, long Friend, float bond, bool pub);

    /// <summary>
    /// Adds user friend returning true if was removed, or false if was not a friend
    /// </summary>
    bool RemoveFriend(long user, long Friend);


    /// <summary>
    /// Returns user by ID or null if not found
    /// </summary>
    User Get(long id);

    /// <summary>
    /// Returns user friends
    /// </summary>
    Circles GetCircles(long id, int ranks, float minBond, bool? pub);
  }
}
