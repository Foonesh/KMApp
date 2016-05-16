namespace Application.DataLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRIRecommendedAllowencesElements
    {
        [Key]
        public int IdDriAllowancesElements { get; set; }

        public float MinAge { get; set; }

        public float MaxAge { get; set; }

        public int Sex { get; set; }

        public float? Calcium { get; set; }

        public float? Chromium { get; set; }

        public float? Copper { get; set; }

        public float? Fluoride { get; set; }

        public float? Iodine { get; set; }

        public float? Iron { get; set; }

        public float? Magnesium { get; set; }

        public float? Manganese { get; set; }

        public float? Molybdenum { get; set; }

        public float? Phosphorus { get; set; }

        public float? Selenium { get; set; }

        public float? Zinc { get; set; }

        public float? Potassium { get; set; }

        public float? Sodium { get; set; }

        public float? Chloride { get; set; }
    }
}
