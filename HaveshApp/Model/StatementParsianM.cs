using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class StatementParsianM
    {
        public string? Description { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? TransactionTime { get; set; }
        public int? DepositAmount { get; set; }
        public string? WithdrawalAmount { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? AgentBranch { get; set; }
        public string? CustomerDescription { get; set; }
        public int Id { get; set; }
    }
}
