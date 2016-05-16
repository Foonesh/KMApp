namespace Application.DataLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRIAverages
    {
        [Key]
        public int IdDriAverage { get; set; }

        public float MinAge { get; set; }

        public float MaxAge { get; set; }

        public int Sex { get; set; }

        public float? Calcium { get; set; }

        public float? CHO { get; set; }

        public float? Protein { get; set; }

        public float? VitA { get; set; }

        public float? VitC { get; set; }

        public float? VitD { get; set; }

        public float? VitE { get; set; }

        public float? Thiamin { get; set; }

        public float? RiboFlavin { get; set; }

        public float? Niacin { get; set; }

        public float? VitB6 { get; set; }

        public float? Folate { get; set; }

        public float? VitB12 { get; set; }

        public float? Copper { get; set; }

        public float? Iodine { get; set; }

        public float? Iron { get; set; }

        public float? Magnesium { get; set; }

        public float? Molybdenum { get; set; }

        public float? Phosphorus { get; set; }

        public float? Selenium { get; set; }

        public float? Zinc { get; set; }
    }
}
