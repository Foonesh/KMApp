using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.PottonIndex
{
    public class PottonIndex:BodyWeightIndex
    {
        public override ICalculatedData CalculateWeightIndex(Person person)
        {
            float Index;
            if (person.sex == Sex.Female)
                Index = person.Heigh - 100 - (person.Heigh - 100)/10;
            else
            {
               Index= person.Heigh - 100 - (person.Heigh - 100)/20;
            }

            return  new PottonCalculatedData(Index);

        }
    }
}
