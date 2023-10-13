using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsSearchTaskAzure
    {
        public int SearchTaskAzureId { get; set; }
        public string SearchTaskAzureType { get; set; } = null!;
        public string? SearchTaskAzureObjectType { get; set; }
        public string? SearchTaskAzureMetadata { get; set; }
        public string SearchTaskAzureAdditionalData { get; set; } = null!;
        public int? SearchTaskAzureInitiatorObjectId { get; set; }
        public int SearchTaskAzurePriority { get; set; }
        public string? SearchTaskAzureErrorMessage { get; set; }
        public DateTime SearchTaskAzureCreated { get; set; }
    }
}
