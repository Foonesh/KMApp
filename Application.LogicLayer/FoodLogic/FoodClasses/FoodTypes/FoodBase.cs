using System.Collections.Generic;
using Application.LogicLayer.FoodLogic.FoodClasses.Enums;
using Application.LogicLayer.FoodLogic.Interfaces;

namespace Application.LogicLayer.FoodLogic.FoodClasses.FoodTypes
{
    class FoodBase : IFood
    {
        public string Name { get; set; }
        public FoodGroup FoodGroup { get; set; }
        public NutritionInfo NutritionInfo { get; set; }
        public List<string> Tags { get; set; }

        public float GetCalories()
        {
            return NutritionInfo.Proximates.Energy.Amount;
        }

        public float GetCalories(int grams)
        {
            float fraction = (float) grams/100;
            return fraction * GetCalories();
        }
    }
    
}
