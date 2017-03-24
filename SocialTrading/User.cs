using System;
using System.Collections.Generic;

using NFX;
using NFX.Collections;
using NFX.DataAccess.Distributed;

namespace SocialTrading
{
  public class User
  {
    public class Trade
    {
      private Trade() { }
      public Trade(GDID id, int prov, long provId, string sym, decimal val, string msg)
      {
        ID = id;
        Provider = prov;
        ProviderID = provId;
        TimestampUTC = App.TimeSource.UTCNow;
        Symbol = sym;
        Value = val;
        Message = msg;
      }
      public GDID     ID          { get;  private set; }
      public int      Provider    { get;  private set; }
      public long     ProviderID  { get;  private set; }
      public DateTime TimestampUTC{ get;  private set; }
      public string   Symbol      { get;  private set; }
      public decimal  Value       { get;  private set; }
      public string   Message     { get;  private set; }
    }

    public const int MAX_TRADE_COUNT = 256;

    private User(){ }
    public User(GDID id)
    {
      ID = id;
      m_Trades = new List<Trade>(16);
    }

    private List<Trade> m_Trades;

    public GDID      ID          { get; private set; }
    public string    Name        { get; set; }
    public DateTime  DOB         { get; set; }
    public StringMap SocialMsg   { get; set; }
    public ulong     BuyerScore  { get; set; }
    public ulong     SellerScore { get; set; }
    public GDID?     GVendor     { get; set; }
    public bool      IsVendor    { get; set; }
    public bool?     PayoutApproved { get; set; }
    public bool?     ReturnApproved { get; set; }
    public IEnumerable<Trade> Trades  { get { return m_Trades; } }
    public float     Age
    {
      get { return (float)(App.TimeSource.Now - DOB).TotalDays / 365f; }
    }

    public void AddTrade(Trade trade)
    {
      if (m_Trades.Count == MAX_TRADE_COUNT)
        m_Trades.RemoveAt(0);

      m_Trades.Add(trade);
    }

  }
}
