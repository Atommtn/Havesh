using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CiMigration
    {
        public int MigrationId { get; set; }
        public string MigrationName { get; set; } = null!;
        public DateTime DateApplied { get; set; }
        public int? RowsAffected { get; set; }
    }
}
