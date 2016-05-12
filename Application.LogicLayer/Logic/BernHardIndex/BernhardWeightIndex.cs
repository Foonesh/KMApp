using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.BernHardIndex
{
    class BernhardWeightIndex:BodyWeightIndex
    {
        public override ICalculatedData CalculateWeightIndex(PersonViewModel person)
        {
            float Index = person.Heigh*person.DataForCalculatedNIndex.chest/240;

           return new BernhardCalcuatedData(Index);
        }
    }
}
