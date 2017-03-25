using System;
using System.Collections.Generic;

using NFX;
using NFX.Collections;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class User
  {
    private User(){ }

    public User(GDID id)
    {
      ID = id;
    }


    public GDID      ID          { get; private set; }
    public string    FirstName   { get; set; }
    public string    LastName    { get; set; }
    public string    Address     { get; set; }
    public DateTime  DOB         { get; set; }
    public StringMap SocialMsg   { get; set; }
    public ulong     BuyerScore  { get; set; }
    public ulong     SellerScore { get; set; }
    public GDID?     GVendor     { get; set; }
    public bool      IsVendor    { get; set; }
    public bool?     PayoutApproved { get; set; }
    public bool?     ReturnApproved { get; set; }

    public float     Age//example business logic
    {
      get { return (float)(App.TimeSource.Now - DOB).TotalDays / 365f; }
    }

  }
}
