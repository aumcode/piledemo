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
  public sealed class NamedMonitor
  {
    public NamedMonitor(bool caseSensitive = false)
    {
      m_Buckets = new Dictionary<string, object>[0xff + 1];
      for(var i=0; i< m_Buckets.Length; i++)
        m_Buckets[i] =  new Dictionary<string, object>(caseSensitive ? StringComparer.Ordinal : StringComparer.OrdinalIgnoreCase);
    }

    private Dictionary<string, object>[] m_Buckets;

    public void Enter(string name)
    {
      var bucket = getBucket(name);
      object _lock;
      lock(bucket)
      {
        if (!bucket.TryGetValue(name, out _lock))
        {
          _lock = new object();
          bucket.Add(name, new object());
        }
      }

      Monitor.Enter(_lock);
    }

    public bool TryEnter(string name, int msTimeout)
    {
      var bucket = getBucket(name);
      object _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(name, out _lock))
        {
          _lock = new object();
          bucket.Add(name, new object());
        }
      }

      return Monitor.TryEnter(_lock, msTimeout);
    }

    public bool Exit(string name)
    {
      var bucket = getBucket(name);
      object _lock;
      lock (bucket)
      {
        if (!bucket.TryGetValue(name, out _lock)) return false;
        Monitor.Exit(_lock);
        bucket.Remove(name);
      }
      return true;
    }


    private Dictionary<string, object> getBucket(string name)
    {
      var hc = name.GetHashCode();
      return m_Buckets[hc & 0xff];
    }
  }
}
