using System;
using Application.LogicLayer.FoodLogic.FoodClasses.NutritionGroups;
using Application.LogicLayer.FoodLogic.Interfaces;

namespace Application.LogicLayer.FoodLogic.FoodClasses
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
