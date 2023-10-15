using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsResourceLibrary
    {
        public int ResourceLibraryId { get; set; }
        public int ResourceLibraryResourceId { get; set; }
        public string ResourceLibraryPath { get; set; } = null!;

        public virtual CmsResource ResourceLibraryResource { get; set; } = null!;
    }
}
