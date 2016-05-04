using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Abstract
{
    public abstract class BodyWeightIndex :IBodyWeightIndex
    {

        public abstract ICalculatedData CalculateWeightIndex(Person person);

    }
}
