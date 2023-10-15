using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class PersonasPersona
    {
        public PersonasPersona()
        {
            PersonasPersonaContactHistories = new HashSet<PersonasPersonaContactHistory>();
        }

        public int PersonaId { get; set; }
        public string PersonaDisplayName { get; set; } = null!;
        public string PersonaName { get; set; } = null!;
        public string? PersonaDescription { get; set; }
        public bool? PersonaEnabled { get; set; }
        public Guid PersonaGuid { get; set; }
        public int PersonaScoreId { get; set; }
        public Guid? PersonaPictureMetafileGuid { get; set; }
        public int PersonaPointsThreshold { get; set; }

        public virtual ICollection<PersonasPersonaContactHistory> PersonasPersonaContactHistories { get; set; }
    }
}
