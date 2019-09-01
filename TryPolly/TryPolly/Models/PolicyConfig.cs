using System;
using System.Collections.Generic;
using System.Text;
using TryPolly.Interfaces;

namespace TryPolly.Models
{
    public class PolicyConfig : ICircuitBreakerPolicyConfig, IRetryPolicyConfig
    {
        public int RetryCount { get; set; }
        public int BreakDuration { get; set; }
    }
}
