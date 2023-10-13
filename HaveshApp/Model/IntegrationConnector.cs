using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class IntegrationConnector
    {
        public IntegrationConnector()
        {
            IntegrationSynchronizations = new HashSet<IntegrationSynchronization>();
        }

        public int ConnectorId { get; set; }
        public string ConnectorName { get; set; } = null!;
        public string ConnectorDisplayName { get; set; } = null!;
        public string ConnectorAssemblyName { get; set; } = null!;
        public string ConnectorClassName { get; set; } = null!;
        public bool? ConnectorEnabled { get; set; }
        public DateTime ConnectorLastModified { get; set; }

        public virtual ICollection<IntegrationSynchronization> IntegrationSynchronizations { get; set; }
    }
}
