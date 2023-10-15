using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComCurrencyExchangeRate
    {
        public int ExchagneRateId { get; set; }
        public int ExchangeRateToCurrencyId { get; set; }
        public decimal ExchangeRateValue { get; set; }
        public int ExchangeTableId { get; set; }
        public Guid ExchangeRateGuid { get; set; }
        public DateTime ExchangeRateLastModified { get; set; }

        public virtual ComCurrency ExchangeRateToCurrency { get; set; } = null!;
        public virtual ComExchangeTable ExchangeTable { get; set; } = null!;
    }
}
