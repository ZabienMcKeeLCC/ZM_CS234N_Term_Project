using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class IngredientSubstitute
    {
        public int IngredientId { get; set; }
        public int SubstituteIngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Ingredient SubstituteIngredient { get; set; }
    }
}
