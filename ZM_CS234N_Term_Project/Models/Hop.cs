﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class Hop
    {
        public int IngredientId { get; set; }
        public int? HopTypeId { get; set; }
        public string Origin { get; set; }
        public double? Alpha { get; set; }
        public double? Beta { get; set; }
        public double? Hsi { get; set; }
        public string Form { get; set; }

        public virtual HopType HopType { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
