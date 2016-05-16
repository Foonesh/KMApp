namespace Application.DataLogicLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseNutrients : DbContext
    {
        public DatabaseNutrients()
            : base("name=DatabaseNutrients")
        {
        }

        public virtual DbSet<ABBREV> ABBREV { get; set; }
        public virtual DbSet<DRIAverages> DRIAverages { get; set; }
        public virtual DbSet<DRIRecommendedAllowancesVitamins> DRIRecommendedAllowancesVitamins { get; set; }
        public virtual DbSet<DRIRecommendedAllowencesElements> DRIRecommendedAllowencesElements { get; set; }
        public virtual DbSet<DRIWaterAndMacroNutrientsAllowances> DRIWaterAndMacroNutrientsAllowances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
