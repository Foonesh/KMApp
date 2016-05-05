namespace Food.Food.Interfaces
{
    interface IFood
    {
        /// <summary>
        /// Gets the amount of calories per 100 grams.
        /// </summary>
        /// <returns></returns>
        float GetCalories();
        /// <summary>
        /// Gets the amount of calories for the specified amount of food.
        /// </summary>
        /// <param name="grams">Amount of grams to calculate calories value for</param>
        /// <returns></returns>
        float GetCalories(int grams);
    }
}
