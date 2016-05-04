using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.BMI
{
   public class BMICalculatedData :ICalculatedData
    {

       public BMICalculatedData(float Index)
       {
           CorrectValues=new Dictionary<string, float>();
           PersonIndex = Index;
       }


       public Dictionary<string, float> CorrectValues { get; set; }
       public float PersonIndex { get; set; }
    }
}
