using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class AdjunctType
    {
        public AdjunctType()
        {
            Adjuncts = new HashSet<Adjunct>();
        }

        public int AdjunctTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Adjunct> Adjuncts { get; set; }
    }
}
