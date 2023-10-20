using HaveshApp.Data;
using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisLevelClass : BranchBaseModel
	{
        public int LevelClassId { get; set; }
        public Guid LevelClassGuid { get; set; }
        public DateTime LevelClassLastModified { get; set; }
        public string LevelName { get; set; } = null!;
        public string? LevelDes { get; set; }
        public string? Grouping { get; set; }
        public int BookId { get; set; }
        public int? NextLevelFk { get; set; }
    }
}
