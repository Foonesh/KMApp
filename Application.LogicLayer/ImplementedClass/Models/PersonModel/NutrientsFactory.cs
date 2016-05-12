using System;
using System.Collections.Generic;
using System.Linq;
using Application.LogicLayer.Interfaces.PersonInterfaces;

namespace Application.LogicLayer.ImplementedClass.Models.PersonModel
{
    public static class NutrientsFactory
    {
        public static INutrients Resolve(int age, float weight, float height)
        {
            //To albo zwykła ifologia (jest poniżej)
            
            Dictionary<string, int> ageRangesDictionary = new Dictionary<string, int>
            {
                {"Baby", 4},
                {"Young", 16},
                {"Adult", 50},
                {"Old", 200}
            };

            INutrients resultNutrients = null;

            var ageSwitch = new Dictionary<Func<int, bool>, Action>
            {
                {
                    x => x < ageRangesDictionary["Baby"], () => { resultNutrients = new BabyNutrients(age, weight, height); }
                },
                {
                    x => x < ageRangesDictionary["Young"], () => { resultNutrients = new YoungNutrients(age, weight, height); }
                },
                {
                    x => x < ageRangesDictionary["Adult"], () => { resultNutrients = new AdultNutrients(age, weight, height); }
                },
                {
                    x => x < ageRangesDictionary["Old"], () => { resultNutrients = new OldNutrients(age, weight, height); }
                }

            };

            ageSwitch.First(item => item.Key(age)).Value.Invoke();

            return resultNutrients;

            /*
            const int babyAge = 4;
            const int youngAge = 16;
            const int adultAge = 50;
            const int oldAge = 200;

            if (age < babyAge)
            {
                return new BabyNutrients(age, weight, height);
            }
            if (age < youngAge)
            {
                return new YoungNutrients(age, weight, height);
            }
            if (age < adultAge)
            {
                return new AdultNutrients(age, weight, height);
            }
            if (age < oldAge)
            {
                return new OldNutrients(age, weight, height);
            }
            
            throw new ArgumentOutOfRangeException(nameof(age));
            */

        }
    }
}
