using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Addresses = new HashSet<Address>();
            IngredientInventoryAdditions = new HashSet<IngredientInventoryAddition>();
        }

        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Note { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<IngredientInventoryAddition> IngredientInventoryAdditions { get; set; }
    }
}
