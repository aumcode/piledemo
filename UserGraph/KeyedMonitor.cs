using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NFX
{
  //todo Move into NFX

  /// <summary>
  /// Provides Monitor services over named objects
  /// </summary>
  public sealed class KeyedMonitor<TKey>
  {
    public KeyedMonitor(IEqualityComparer<TKey> comparer = null)
    {
      m_Buckets = new Dictionary<TKey, object>[0xff + 1];
      for(var i=0; i< m_Buckets.Length; i++)
        m_Buckets[i] =  comparer !=null ? new Dictionary<TKey, object>(comparer) : new Dictionary<TKey, object>();
    }

    private Dictionary<TKey, object>[] m_Buckets;


    public void Synchronized(TKey key, Action action)
    {
      Enter(key);
      try
      {
        action();
      }
      finally
      {
        Exit(key);
      }
    }

    public TResult Synchronized<TResult>(TKey key, Func<TResult> action)
    {
      Enter(key);
      try
      {
        return action();
      }
      finally
      {
        Exit(key);
      }
    }

    public void Enter(TKey key)
    {
      var bucket = getBucket(key);
      object _lock;
      lock(bucket)
      {
        if (!bucket.TryGetValue(key, out _lock))
        {
          _lock = new object();
          bucket.Add(key, new object());
        }
      }

      Monitor.Enter(_lock);
    }

    public bool TryEnter(TKey key, int msTimeout)
    {
      var bucket = getBucket(key);
      object _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(key, out _lock))
        {
          _lock = new object();
          bucket.Add(key, new object());
        }
      }

      return Monitor.TryEnter(_lock, msTimeout);
    }

    public bool Exit(TKey key)
    {
      var bucket = getBucket(key);
      object _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(key, out _lock)) return false;
        Monitor.Exit(_lock);
        bucket.Remove(key);
      }
      return true;
    }


    private Dictionary<TKey, object> getBucket(TKey key)
    {
      var hc = key.GetHashCode();
      return m_Buckets[hc & 0xff];
    }
  }
}
