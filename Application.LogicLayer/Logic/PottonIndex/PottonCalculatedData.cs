using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.PottonIndex
{
    class PottonCalculatedData:ICalculatedData
    {
        public PottonCalculatedData(float Index)
        {
            PersonIndex = Index;
        }
        public Dictionary<string, float> CorrectValues { get; set; }
        public float PersonIndex { get; set; }
    }
}
