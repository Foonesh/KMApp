using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Logic.BMI;
using Application.LogicLayer.Logic.BrockIndex;
using Application.LogicLayer.Logic.LorentzIndex;
using Application.LogicLayer.Logic.PottonIndex;
using Application.LogicLayer.Logic.USLifeInsurenceIndex;
using Models;

namespace Controllers
{
    public class UserIndexCalcController : Controller
    {
        // GET: UserIndexCalc
        [HttpGet]
        public ActionResult BasicCalcData()
        {

            return View();
        }
         
        [HttpPost]
        public ActionResult BasicCalcData(PersonViewModel PersonViewmodel)
        {
            Dictionary<string, BodyWeightIndex> DictIndex = new Dictionary<string, BodyWeightIndex>()
            {
                {"BMI",new BMIWeightIndex() },
                {"Brock",new BrockWeightIndex() },
                {"BrockBrush",new BrockWeightIndex() },
                {"Lorentz",new LorentzIndex() },
                {"Potton",new PottonIndex() },
                {"UsInsurence",new UsInsurenceIndex() },

            };
                
               IndexesViewModel view = new IndexesViewModel();

            view.BMI = DictIndex["BMI"].CalculateWeightIndex(PersonViewmodel).PersonIndex;
            view.BrockIndex = DictIndex["Brock"].CalculateWeightIndex(PersonViewmodel).PersonIndex;
            view.BrockBrush = DictIndex["BrockBrush"].CalculateWeightIndex(PersonViewmodel).PersonIndex;
            view.Lorentz = DictIndex["Lorentz"].CalculateWeightIndex(PersonViewmodel).PersonIndex;
            view.Potton = DictIndex["Potton"].CalculateWeightIndex(PersonViewmodel).PersonIndex;
            view.UsInsurence = DictIndex["UsInsurence"].CalculateWeightIndex(PersonViewmodel).PersonIndex;




            return PartialView("_IndexesPartialView", view);

        }


    }
}