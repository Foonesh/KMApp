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
        public int Age { get; set; }
        public float Weight { get; set; }
        public float Heigth { get; set; }

        public INutrients Nutrients { get; set; }

        
    }

    
}