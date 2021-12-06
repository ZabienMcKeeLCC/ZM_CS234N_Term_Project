﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ZM_CS234N_Term_Project.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Batches = new HashSet<Batch>();
            RecipeIngredients = new HashSet<RecipeIngredient>();
        }

        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int? Version { get; set; }
        public DateTime? Date { get; set; }
        public int StyleId { get; set; }
        public double Volume { get; set; }
        public string Brewer { get; set; }
        public double? BoilTime { get; set; }
        public double? BoilVolume { get; set; }
        public double? Efficiency { get; set; }
        public int? FermentationStages { get; set; }
        public double? EstimatedOg { get; set; }
        public double? EstimatedFg { get; set; }
        public double? EstimatedColor { get; set; }
        public double? EstimatedAbv { get; set; }
        public double? ActualEfficiency { get; set; }
        public int? EquipmentId { get; set; }
        public string CarbonationUsed { get; set; }
        public byte? ForcedCarbonation { get; set; }
        public double? KegPrimingFactor { get; set; }
        public double? CarbonationTemp { get; set; }
        public int? MashId { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Mash Mash { get; set; }
        public virtual Style Style { get; set; }
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
