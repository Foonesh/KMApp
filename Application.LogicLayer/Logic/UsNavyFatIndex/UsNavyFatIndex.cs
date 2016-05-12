using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.HelpersData;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.Logic.UsNavyFatIndex
{
    public class UsNavyFatIndex:BodyWeightIndex
    {    
         
        public override ICalculatedData CalculateWeightIndex(PersonViewModel person)
        {
                CalculatedNavyIndexData dataNavy = new CalculatedNavyIndexData();


            if (person.Sex == Sex.Male)
            {
                dataNavy.PersonIndex = (float) ((float) (86.010*Math.Log10((double) person.DataForCalculatedNIndex.abdomen-
                          person.DataForCalculatedNIndex.neck)-70.041 *Math.Log10(person.Heigh))+36.76);
            }
            else if (person.Sex == Sex.Female)
            {
                dataNavy.PersonIndex = (float)((float)(163.205 * Math.Log10((double)person.DataForCalculatedNIndex.abdomen +
                    person.DataForCalculatedNIndex.hip-
                     person.DataForCalculatedNIndex.neck) - 97.684 * Math.Log10(person.Heigh)) -78.387);
            }


            return dataNavy;
            // http://www.bodybuilding.com/fun/kurilla5.pdf
        }
    }
}
