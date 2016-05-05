using System;
using Food.Food.Interfaces;
using Food.Food.NutritionGroups;

namespace Food.Food.FoodClasses
{
    class NutritionInfo : INutritionInfo
    {
        //https://ndb.nal.usda.gov/ndb/foods



        public Proximates Proximates { get; set; }
        public Minerals Minerals { get; set; }
        public Vitamins Vitamins { get; set; }
        public Lipids Lipids { get; set; }
        public AminoAcids AminoAcids { get; set; }

        public float GetNutrientValue(string nutrient)
        {
            throw new NotImplementedException();
        }
    }
}
