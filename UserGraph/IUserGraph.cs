using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX.DataAccess.Distributed;

namespace UserGraph
{

  public class User
  {
    public User() { }

    public long     ID               { get; set; }
    public string   Name             { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime LastLoginDate    { get; set; }
    public string   EMail            { get; set; }
    public bool     CanVote          { get; set; }
    public string   Location         { get; set; }
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
    public long[] MentionUserIDs { get; set; }
  }


  public interface IUserGraph
  {
    long UserCount { get; }
    long PostCount { get; }

    /// <summary>
    /// Add or update user, true if added
    /// </summary>
    bool PutUser(User user);

    /// <summary>
    /// Remove user by ID, true if found and removed
    /// </summary>
    bool RemoveUser(long userID);

    /// <summary>
    /// Add or replace post, true if added
    /// </summary>
    bool PutPost(Post post);

    /// <summary>
    /// Remove post by id
    /// </summary>
    bool RemovePost(long postID);

    /// <summary>
    /// Vote foir post +/-
    /// </summary>
    bool VotePost(long postID, int count);

    /// <summary>
    /// Gets postes authored by user
    /// </summary>
    IEnumerable<Post> GetUserPosts(long userID, out User user);

    /// <summary>
    /// Get posts that have the user mentioned
    /// </summary>
    IEnumerable<KeyValuePair<User, Post>> GetMentionedUserPosts(long userID);
  }
}
