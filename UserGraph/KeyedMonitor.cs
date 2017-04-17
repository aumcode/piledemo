using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NFX
{
  //todo Move into NFX

  /// <summary>
  /// Provides Monitor services over keyed objects
  /// </summary>
  public sealed class KeyedMonitor<TKey>
  {
    private class _slot
    {
      public _slot() { RefCount = 1; }
      public int RefCount;
    }



    public KeyedMonitor(IEqualityComparer<TKey> comparer = null)
    {
      m_Buckets = new Dictionary<TKey, _slot>[0xff + 1];
      for(var i=0; i< m_Buckets.Length; i++)
        m_Buckets[i] =  comparer !=null ? new Dictionary<TKey, _slot>(comparer) : new Dictionary<TKey, _slot>();
    }

    private Dictionary<TKey, _slot>[] m_Buckets;


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
      _slot _lock;
      lock(bucket)
      {
        if (!bucket.TryGetValue(key, out _lock))
        {
          _lock = new _slot();
          bucket.Add(key, _lock);
        }
        else
          _lock.RefCount++;
      }

      Monitor.Enter(_lock);
    }

    public bool TryEnter(TKey key, int msTimeout)
    {
      var bucket = getBucket(key);
      _slot _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(key, out _lock))
        {
          _lock = new _slot();
          bucket.Add(key, _lock);
        }
        else
          _lock.RefCount++;
      }

      //if lock was not taken - someone else will delete after Exit()
      return Monitor.TryEnter(_lock, msTimeout);
    }

    public bool Exit(TKey key)
    {
      var bucket = getBucket(key);
      _slot _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(key, out _lock)) return false;
        Monitor.Exit(_lock);
        _lock.RefCount--;
        if (_lock.RefCount==0)
          bucket.Remove(key);
      }
      return true;
    }


    private Dictionary<TKey, _slot> getBucket(TKey key)
    {
      var hc = key.GetHashCode();
      return m_Buckets[hc & 0xff];
    }
  }
}
