using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.UsNavyFatIndex
{
    public class UsNavyFatIndex:BodyWeightIndex
    {    
         
        public override ICalculatedData CalculateWeightIndex(Person person)
        {

            return null;
           // http://www.bodybuilding.com/fun/kurilla5.pdf
        }
    }
}
