using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Interfaces.PersonInterfaces;

namespace Application.LogicLayer.ImplementedClass
{
    class OldNutrients : INutrients
    {
        public OldNutrients(int age, float weight, float heigth)
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
