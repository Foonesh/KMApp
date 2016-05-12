using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.BMI
{
   public class BMIWeightIndex:BodyWeightIndex
    {
       public override ICalculatedData CalculateWeightIndex(PersonViewModel person)
       {
           //float divider = ;
              
           float Index = person.Weight/((person.Heigh/100)*(person.Heigh/100));
           return new BMICalculatedData(Index);
       }
    }
}
