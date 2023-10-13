using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComCurrency
    {
        public ComCurrency()
        {
            ComCurrencyExchangeRates = new HashSet<ComCurrencyExchangeRate>();
            ComOrders = new HashSet<ComOrder>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; } = null!;
        public string CurrencyDisplayName { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public int? CurrencyRoundTo { get; set; }
        public bool CurrencyEnabled { get; set; }
        public string CurrencyFormatString { get; set; } = null!;
        public bool CurrencyIsMain { get; set; }
        public Guid? CurrencyGuid { get; set; }
        public DateTime CurrencyLastModified { get; set; }
        public int? CurrencySiteId { get; set; }

        public virtual CmsSite? CurrencySite { get; set; }
        public virtual ICollection<ComCurrencyExchangeRate> ComCurrencyExchangeRates { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
    }
}
