using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.BrockIndex
{
    public class BrockWeightIndex:BodyWeightIndex
    {
        public override ICalculatedData CalculateWeightIndex(Person person)
        {
            float Index;
            if (person.Sex == Sex.Female)
            {
                Index = (float) ((person.Heigh - 100)*0.85);
            }
            else
            {
               Index= (float)((person.Heigh - 100) * 0.90);
            }
            return new BrockCalculatedData(Index);
        }

    }
}

