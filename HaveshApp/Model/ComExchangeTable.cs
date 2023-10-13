using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComExchangeTable
    {
        public ComExchangeTable()
        {
            ComCurrencyExchangeRates = new HashSet<ComCurrencyExchangeRate>();
        }

        public int ExchangeTableId { get; set; }
        public string ExchangeTableDisplayName { get; set; } = null!;
        public DateTime? ExchangeTableValidFrom { get; set; }
        public DateTime? ExchangeTableValidTo { get; set; }
        public Guid ExchangeTableGuid { get; set; }
        public DateTime ExchangeTableLastModified { get; set; }
        public int? ExchangeTableSiteId { get; set; }
        public decimal? ExchangeTableRateFromGlobalCurrency { get; set; }

        public virtual CmsSite? ExchangeTableSite { get; set; }
        public virtual ICollection<ComCurrencyExchangeRate> ComCurrencyExchangeRates { get; set; }
    }
}
