using System;
using System.Collections.Generic;

using NFX.DataAccess.Distributed;


namespace SocialTrading
{
  /// <summary>
  /// Denotes a contract for the entoty that acts like a store for social user trading
  /// The implementation must be thread-safe for parallel user processing
  /// </summary>
  public interface IUserStore
  {


    long IDSeed { get; }

    GDID MakeID();


    /// <summary>
    /// Puts user into the store. Returns true if was added, otherwise replaces the existing one
    /// </summary>
    bool Put(User user);

    /// <summary>
    /// Fetches user from the store by global ID or null if not found
    /// </summary>
    User Get(GDID gUser);

    /// <summary>
    /// Deletes the specified user from the store identified by global id.
    /// Returns true if found and deleted
    /// </summary>
    bool Remove(GDID gUser);

    /// <summary>
    /// Returns the count of users in the store
    /// </summary>
    long Count { get; }

    /// <summary>
    /// Add the trade to user object returning it, or null if user was not found
    /// </summary>
    User AcceptTrade(GDID gUser, User.Trade trade);

    /// <summary>
    /// Deletes all
    /// </summary>
    void Purge();
  }
}
