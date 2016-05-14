using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.LogicLayer.Abstract;
using Application.LogicLayer.HelpersData;
using Application.LogicLayer.ImplementedClass;
using Application.LogicLayer.Logic.BernHardIndex;
using Application.LogicLayer.Logic.BMI;
using Application.LogicLayer.Logic.BrockIndex;
using Application.LogicLayer.Logic.LorentzIndex;
using Application.LogicLayer.Logic.PottonIndex;
using Application.LogicLayer.Logic.UsNavyFatIndex;
using Application.LogicLayer.Logic.USLifeInsurenceIndex;
using Models;

namespace Controllers
{
    public class ExtendedUserIndexCalcController : Controller
    {
        // GET: ExtendedUserIndexCalc
        public ActionResult ExtendedIndex()
        {       
            UsNavyIndexData UsNavyData = new UsNavyIndexData();


            return View("ExtendedIndexView");
        }
        [HttpPost]
        public ActionResult ExtendedIndex(UsNavyIndexData navyIndData)
        {
            Dictionary<string, BodyWeightIndex> DictIndex = new Dictionary<string, BodyWeightIndex>()
            {
                {"FatUsNavyIndex",new UsNavyFatIndex() },
                {"BernahrdIndex" ,new BernhardWeightIndex()}

            };

            PersonViewModel model = new PersonViewModel(navyIndData);
            model.Heigh = 193;
            model.Weight=71;
            model.Sex=Sex.Male;
            model.Age=27;
             
            ExtendedIndexesViewModel viewExtendedModel = new ExtendedIndexesViewModel();

            viewExtendedModel.UsNavyFatIndex= DictIndex["FatUsNavyIndex"].CalculateWeightIndex(model).PersonIndex;
            viewExtendedModel.BernhardIndex = DictIndex["BernahrdIndex"].CalculateWeightIndex(model).PersonIndex;




            return PartialView("_CalcExtendedDataPartialView", viewExtendedModel);

         





                                
        }

    }
}