namespace Application.LogicLayer.Food.Interfaces
{
    interface INutritionInfo
    {
        /// <summary>
        /// Returns amount of specified nutrient per 100g (in grams).
        /// </summary>
        /// <param name="nutrient">The nutrient to look for</param>
        float GetNutrientValue(string nutrient);
    }
}
