using Application.LogicLayer.Interfaces.PersonInterfaces;

namespace Application.LogicLayer.ImplementedClass.Models.PersonModel
{
    class YoungNutrients : INutrients
    {
        public YoungNutrients(int age, float weight, float heigth)
        {
            //set values
            CalculateRequirements(age);
        }
        public int Magnesium { get; set; }
        private void CalculateRequirements(int age, string physicalActivity = "medium")
        {
            Magnesium = age * 2 + 10;
        }
    }
}
