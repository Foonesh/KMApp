namespace Application.DataLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRIRecommendedAllowancesVitamins
    {
        [Key]
        public int IdDriRecommended { get; set; }

        public float MinAge { get; set; }

        public float MaxAge { get; set; }

        public int Sex { get; set; }

        public float? VitA { get; set; }

        public float? VitC { get; set; }

        public float? VitD { get; set; }

        public float? VitE { get; set; }

        public float? VitK { get; set; }

        public float? Thiamin { get; set; }

        public float? RiboFlavin { get; set; }

        public float? Niacin { get; set; }

        public float? VitB6 { get; set; }

        public float? Folate { get; set; }

        public float? VitB12 { get; set; }

        public float? PantothenicAcid { get; set; }

        public float? Biotin { get; set; }

        public float? Choline { get; set; }
    }
}
