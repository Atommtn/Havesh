using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsMacroRule
    {
        public int MacroRuleId { get; set; }
        public string MacroRuleName { get; set; } = null!;
        public string MacroRuleText { get; set; } = null!;
        public string? MacroRuleParameters { get; set; }
        public string? MacroRuleResourceName { get; set; }
        public DateTime MacroRuleLastModified { get; set; }
        public Guid MacroRuleGuid { get; set; }
        public string MacroRuleCondition { get; set; } = null!;
        public string MacroRuleDisplayName { get; set; } = null!;
        public bool? MacroRuleIsCustom { get; set; }
        public bool MacroRuleRequiresContext { get; set; }
        public string? MacroRuleDescription { get; set; }
        public string? MacroRuleRequiredData { get; set; }
        public bool? MacroRuleEnabled { get; set; }
        public int? MacroRuleAvailability { get; set; }
    }
}
