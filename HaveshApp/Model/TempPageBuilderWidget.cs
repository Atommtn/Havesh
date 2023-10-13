using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class TempPageBuilderWidget
    {
        public int PageBuilderWidgetsId { get; set; }
        public string? PageBuilderWidgetsConfiguration { get; set; }
        public Guid PageBuilderWidgetsGuid { get; set; }
        public DateTime PageBuilderWidgetsLastModified { get; set; }
        public string? PageBuilderTemplateConfiguration { get; set; }
    }
}
