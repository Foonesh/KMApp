namespace Application.DataLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DRIWaterAndMacroNutrientsAllowances
    {
        [Key]
        public int IdDRIWaterAndMactro { get; set; }

        public float MinAge { get; set; }

        public float MaxAge { get; set; }

        public int Sex { get; set; }

        public float? TotalWater { get; set; }

        public float? Carbohydrate { get; set; }

        public float? TotalFiber { get; set; }

        public float? Fat { get; set; }

        public float? LinoleicAcid { get; set; }

        public float? AlfaLinoleicAcid { get; set; }

        public float? Protein { get; set; }
    }
}
