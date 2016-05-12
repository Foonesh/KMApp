using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.HelpersData;
using Application.LogicLayer.Interfaces;

namespace Application.LogicLayer.ImplementedClass
{
    public enum Sex
    {
        Female,
        Male

    };
    public class PersonViewModel
    {
        public PersonViewModel()
        {

        }
        public PersonViewModel(IUsNavyIndexData dataForNavyIdnex)
        {
            DataForCalculatedNIndex = dataForNavyIdnex;
        }
        //=====podstawowe dane
        public float Weight { get; set; }
        public float Heigh { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }



        public IUsNavyIndexData DataForCalculatedNIndex { get; set; }








        //http://facet.onet.pl/forma/jak-zmierzyc-poziom-tkanki-tluszczowej/wqt97





    }
}

