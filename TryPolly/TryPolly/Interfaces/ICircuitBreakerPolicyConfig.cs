using System;
using System.Collections.Generic;
using System.Text;

namespace TryPolly.Interfaces
{
    public interface ICircuitBreakerPolicyConfig
    {
        int RetryCount { get; set; }

        int BreakDuration { get; set; }
    }
}
