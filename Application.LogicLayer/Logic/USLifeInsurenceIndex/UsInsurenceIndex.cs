using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.USLifeInsurenceIndex
{
    class UsInsurenceIndex :BodyWeightIndex
    {
        public override ICalculatedData CalculateWeightIndex(Person person)
        {
            float Index=(float) (50+0.75*(person.Heigh - 150));

            return new UsLifeInsuranceCalcData(Index);

        }
    }
}
