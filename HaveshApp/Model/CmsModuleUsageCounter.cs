using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsModuleUsageCounter
    {
        public int ModuleUsageCounterId { get; set; }
        public string ModuleUsageCounterName { get; set; } = null!;
        public long ModuleUsageCounterValue { get; set; }
    }
}
