using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFX;
using NFX.Environment;
using NFX.ServiceModel;

namespace PD.SocialTrading
{
  /// <summary>
  /// Performs the emulation of business logic
  /// </summary>
  public class Emulator : Service
  {

    private int m_ThreadCount = 1;

    [Config]
    public int ThreadCount
    {
      get { return m_ThreadCount; }
      set { m_ThreadCount = value < 1 ? 1 : value; }
    }

    protected override void DoStart()
    {
      base.DoStart();
    }

    protected override void DoWaitForCompleteStop()
    {
      base.DoWaitForCompleteStop();
    }

  }
}
