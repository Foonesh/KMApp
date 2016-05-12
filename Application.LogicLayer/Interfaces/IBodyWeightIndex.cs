using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.ImplementedClass;

namespace Application.LogicLayer.Interfaces
{
   public interface IBodyWeightIndex
   {
       ICalculatedData CalculateWeightIndex(PersonViewModel person); //berzemy pod uwage zwierzeta? xD

   }
}
