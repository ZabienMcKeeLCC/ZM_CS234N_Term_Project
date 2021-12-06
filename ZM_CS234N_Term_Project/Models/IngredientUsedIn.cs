using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class IngredientUsedIn
    {
        public int IngredientId { get; set; }
        public int StyleId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Style Style { get; set; }
    }
}
