using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.BrogBrugshIndex
{
    public class BrocBrugshIndex:BodyWeightIndex
    {
       // Dictionary<> 

        public override ICalculatedData CalculateWeightIndex(Person person)
        {
            float Index=new float();
            if (person.Heigh >= 155 && person.Heigh < 165)
                Index = person.Heigh/=-100;
            else if (person.Heigh >= 165 && person.Heigh < 176)
                Index = person.Heigh - 105;
            else if (person.Heigh >= 176)
                Index = person.Heigh - 110;

            return new BrocBrugshData(Index);



        }
    }
}
