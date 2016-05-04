using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.LorentzIndex
{
   public class LorentzIndex:BodyWeightIndex
    {
       public override ICalculatedData CalculateWeightIndex(Person person)
       {
           float Index;
            if (person.sex == Sex.Female)
            {
                Index = (float)(person.Heigh - 100 - 0.5 * (person.Heigh - 150));
            }
            else
            {
                Index = (float)(person.Heigh - 100 - 0.25 * (person.Heigh - 150));
            }

            return new LorentzCalculatedData(Index);
       }
    }
}
