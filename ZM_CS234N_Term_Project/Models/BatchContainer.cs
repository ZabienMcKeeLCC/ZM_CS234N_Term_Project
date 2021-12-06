using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class BatchContainer
    {
        public int BatchId { get; set; }
        public int BrewContainerId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public double? Volume { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual BrewContainer BrewContainer { get; set; }
    }
}
