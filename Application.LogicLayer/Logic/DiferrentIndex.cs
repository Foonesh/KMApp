using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic
{
    public class DiferrentIndex
    {
        public ICalculatedData dupa(BodyWeightIndex index)
        {
           return index.CalculateWeightIndex(new PersonViewModel());
        }

    }
}
