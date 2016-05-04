using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.USLifeInsurenceIndex
{
    class UsLifeInsuranceCalcData   :ICalculatedData
    {
        public UsLifeInsuranceCalcData(float Index)
        {
            PersonIndex = Index;
        }
        public Dictionary<string, float> CorrectValues { get; set; }
        public float PersonIndex { get; set; }
    }
}
