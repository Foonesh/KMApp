namespace Application.DataLogicLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ABBREV")]
    public partial class ABBREV
    {
        [Key]
        [StringLength(5)]
        public string NDB_No { get; set; }

        [StringLength(60)]
        public string Shrt_Desc { get; set; }

        [Column("Water_(g)")]
        public double? Water__g_ { get; set; }

        public int? Energ_Kcal { get; set; }

        [Column("Protein_(g)")]
        public double? Protein__g_ { get; set; }

        [Column("Lipid_Tot_(g)")]
        public double? Lipid_Tot__g_ { get; set; }

        [Column("Ash_(g)")]
        public double? Ash__g_ { get; set; }

        [Column("Carbohydrt_(g)")]
        public double? Carbohydrt__g_ { get; set; }

        [Column("Fiber_TD_(g)")]
        public double? Fiber_TD__g_ { get; set; }

        [Column("Sugar_Tot_(g)")]
        public double? Sugar_Tot__g_ { get; set; }

        [Column("Calcium_(mg)")]
        public int? Calcium__mg_ { get; set; }

        [Column("Iron_(mg)")]
        public double? Iron__mg_ { get; set; }

        [Column("Magnesium_(mg)")]
        public double? Magnesium__mg_ { get; set; }

        [Column("Phosphorus_(mg)")]
        public int? Phosphorus__mg_ { get; set; }

        [Column("Potassium_(mg)")]
        public int? Potassium__mg_ { get; set; }

        [Column("Sodium_(mg)")]
        public int? Sodium__mg_ { get; set; }

        [Column("Zinc_(mg)")]
        public double? Zinc__mg_ { get; set; }

        [Column("Copper_mg)")]
        public double? Copper_mg_ { get; set; }

        [Column("Manganese_(mg)")]
        public double? Manganese__mg_ { get; set; }

        [Column("Selenium_(µg)")]
        public double? Selenium__µg_ { get; set; }

        [Column("Vit_C_(mg)")]
        public double? Vit_C__mg_ { get; set; }

        [Column("Thiamin_(mg)")]
        public double? Thiamin__mg_ { get; set; }

        [Column("Riboflavin_(mg)")]
        public double? Riboflavin__mg_ { get; set; }

        [Column("Niacin_(mg)")]
        public double? Niacin__mg_ { get; set; }

        [Column("Panto_Acid_mg)")]
        public double? Panto_Acid_mg_ { get; set; }

        [Column("Vit_B6_(mg)")]
        public double? Vit_B6__mg_ { get; set; }

        [Column("Folate_Tot_(µg)")]
        public double? Folate_Tot__µg_ { get; set; }

        [Column("Folic_Acid_(µg)")]
        public double? Folic_Acid__µg_ { get; set; }

        [Column("Food_Folate_(µg)")]
        public double? Food_Folate__µg_ { get; set; }

        [Column("Folate_DFE_(µg)")]
        public double? Folate_DFE__µg_ { get; set; }

        [Column("Choline_Tot_ (mg)")]
        public double? Choline_Tot___mg_ { get; set; }

        [Column("Vit_B12_(µg)")]
        public double? Vit_B12__µg_ { get; set; }

        public int? Vit_A_IU { get; set; }

        public double? Vit_A_RAE { get; set; }

        [Column("Retinol_(µg)")]
        public double? Retinol__µg_ { get; set; }

        [Column("Alpha_Carot_(µg)")]
        public double? Alpha_Carot__µg_ { get; set; }

        [Column("Beta_Carot_(µg)")]
        public double? Beta_Carot__µg_ { get; set; }

        [Column("Beta_Crypt_(µg)")]
        public double? Beta_Crypt__µg_ { get; set; }

        [Column("Lycopene_(µg)")]
        public double? Lycopene__µg_ { get; set; }

        [Column("Lut+Zea_ (µg)")]
        public double? Lut_Zea___µg_ { get; set; }

        [Column("Vit_E_(mg)")]
        public double? Vit_E__mg_ { get; set; }

        public double? Vit_D_µg { get; set; }

        public double? Vit_D_IU { get; set; }

        [Column("Vit_K_(µg)")]
        public double? Vit_K__µg_ { get; set; }

        [Column("FA_Sat_(g)")]
        public double? FA_Sat__g_ { get; set; }

        [Column("FA_Mono_(g)")]
        public double? FA_Mono__g_ { get; set; }

        [Column("FA_Poly_(g)")]
        public double? FA_Poly__g_ { get; set; }

        [Column("Cholestrl_(mg)")]
        public int? Cholestrl__mg_ { get; set; }

        public double? GmWt_1 { get; set; }

        [StringLength(120)]
        public string GmWt_Desc1 { get; set; }

        public double? GmWt_2 { get; set; }

        [StringLength(120)]
        public string GmWt_Desc2 { get; set; }

        public int? Refuse_Pct { get; set; }
    }
}
