using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.ImplementedClass.Models.PersonModel;

namespace Application.LogicLayer.ImplementedClass
{
    public static class CaloriesCalculator
    {
        //trzeba zrobić w formularzach albo gdzieś indziej walidację danych
        public static double CalculateCaloriesRequirement(PersonRequirements person)
        {
            Dictionary<string, Func<PersonRequirements, double>> caloriesDataDictionary 
                = new Dictionary<string, Func<PersonRequirements, double>>
            {
                {"Infants0-3m", x=> 89*x.Weight - 100 + 175},
                {"Infants4-6m", x=> 89*x.Weight - 100 + 56},
                {"Infants7-12m", x=> 89*x.Weight - 100 + 22},
                {"Infants13-36m", x=> 89*x.Weight - 100 + 20},
                {"Boys3-8y", x=> 88.5-61.9*x.Age+x.PhysicalActivityCoeff*(26.7*x.Weight+903*x.Heigth)+20},
                {"Boys9-18y", x=> 88.5-61.9*x.Age+x.PhysicalActivityCoeff*(26.7*x.Weight+903*x.Heigth)+25},
                {"Men19+y", x=> 662-9.53*x.Age+x.PhysicalActivityCoeff*(15.91*x.Weight+539.6*x.Heigth)},
                {"Girls3-8y", x=> 135.3-30.8*x.Age+x.PhysicalActivityCoeff*(10*x.Weight+934*x.Heigth)+20},
                {"Girls9-18y", x=> 135.3-30.8*x.Age+x.PhysicalActivityCoeff*(10*x.Weight+934*x.Heigth)+25},
                {"Women19+y", x=> 354-6.91*x.Age+x.PhysicalActivityCoeff*(9.36*x.Weight+726*x.Heigth)}
            };

            string group = DetermineAgeGroup(person);

            double result = caloriesDataDictionary[group].Invoke(person);
            
            return result;
        }

        private static string DetermineAgeGroup(PersonRequirements person)
        {
            if (person.Sex == Sex.Female)
            {
                if (person.Age <= 3) return "Infants13-36m";
                if (person.Age <= 8) return "Girls3-8y";
                if (person.Age <= 18) return "Girls9-18y";
                return "Women19+y";
            }
            if (person.Sex == Sex.Male)
            {
                if (person.Age <= 3) return "Infants13-36m";
                if (person.Age <= 8) return "Boys3-8y";
                if (person.Age <= 18) return "Boys9-18y";
                return "Men19+y";
            }
            throw new ArgumentOutOfRangeException(nameof(person.Sex));
        }
    }
}
