using System;
using System.Collections.Generic;
using System.Text;

namespace TryPolly.Interfaces
{
    public interface IRetryPolicyConfig
    {
        int RetryCount { get; set; }
    }
}
