using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class ContainerStatus
    {
        public ContainerStatus()
        {
            BrewContainers = new HashSet<BrewContainer>();
        }

        public int ContainerStatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BrewContainer> BrewContainers { get; set; }
    }
}
