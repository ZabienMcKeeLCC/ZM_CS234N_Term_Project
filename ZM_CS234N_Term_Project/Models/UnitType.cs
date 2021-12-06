using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class UnitType
    {
        public UnitType()
        {
            Ingredients = new HashSet<Ingredient>();
        }

        public int UnitTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
