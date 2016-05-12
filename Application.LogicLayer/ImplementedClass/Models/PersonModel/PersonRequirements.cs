using Application.LogicLayer.Interfaces.PersonInterfaces;

namespace Application.LogicLayer.ImplementedClass.Models.PersonModel
{
    public class PersonRequirements
    {
        public PersonRequirements(int age, float weight, float heigth)
        {
            Age = age;

            Nutrients = NutrientsFactory.Resolve(age, weight, heigth);

        }

        public Sex Sex { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        //wzrost w metrach (do wyliczeń w CaloriesCalculator.cs
        public float Heigth { get; set; }
        public double PhysicalActivityCoeff { get; set; }

        //domyślnie będziemy to zapisywać do bazy z innymi danymi użytkownika za pierwszym wywołaniem
        //CaloriesRequirement, a potem zamiast liczyć pobieramy wcześniej wyliczoną wartość
        //przeliczamy ponownie przy evencie zmiany danych wpływających na wyliczenia.
        //argumentem nie będzie this (czyli PersonRequirements) tylko age, weight, height, activityLevel
        private double _caloriesRequirement;
        public double CaloriesRequirement
        {
            get
            {
                return CaloriesCalculator.CalculateCaloriesRequirement(this);
            }
            set
            {
                _caloriesRequirement = value;
            }
        }

        public INutrients Nutrients { get; set; }

        
    }

    
}