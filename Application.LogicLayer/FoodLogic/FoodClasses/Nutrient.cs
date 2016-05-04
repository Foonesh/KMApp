using Application.LogicLayer.FoodLogic.FoodClasses.Enums;

namespace Application.LogicLayer.FoodLogic.FoodClasses
{
    class Nutrient
    {
        public string Name { get; private set; }
        public Unit Unit { get; private set; }
        public float Amount { get; private set; } //per 100g

        public Nutrient(string name, Unit unit, float amount)
        {
            Name = name;
            Unit = unit;
            Amount = amount;
        }
    }
    
}
