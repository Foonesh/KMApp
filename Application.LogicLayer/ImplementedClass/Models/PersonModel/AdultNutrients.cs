﻿using Application.LogicLayer.Interfaces.PersonInterfaces;

namespace Application.LogicLayer.ImplementedClass.Models.PersonModel
{
    class AdultNutrients : INutrients
    {
        public AdultNutrients(int age, double weight, double heigth)
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
