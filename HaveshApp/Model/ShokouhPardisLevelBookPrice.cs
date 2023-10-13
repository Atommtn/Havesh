using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisLevelBookPrice
    {
        public int LevelBookPriceId { get; set; }
        public Guid LevelBookPriceGuid { get; set; }
        public DateTime LevelBookPriceLastModified { get; set; }
        public int TermId { get; set; }
        public int LevelId { get; set; }
        public int TuitionAmount { get; set; }
        public int BookPrice { get; set; }
    }
}
