using System.Collections.Generic;
using Food.Food.Enums;
using Food.Food.FoodClasses;
using Food.Food.Interfaces;

namespace Food.Food.FoodTypes
{
    class FoodBase : IFood
    {
        public string Name { get; set; }
        //grupa zawarta w polu albo osobna klasa dla każdej, zależy jak lepiej dla bazy
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
