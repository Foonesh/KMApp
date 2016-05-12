using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.DataLogicLayer;
using Application.LogicLayer.ImplementedClass.Models.PersonModel;

namespace Controllers
{
    public class MyUserController : Controller
    {
        //temporary model
        private PersonRequirements _person = new PersonRequirements(26, 75, 193);
        // GET: MyUser
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Get()
        {
            using (DatabaseModel model = new DatabaseModel())
            {
                //var res = model.ABBREV.Select(item => item.Energ_Kcal > 10).Take(5).ToList();



                var alldata = model.ABBREV.First();
                var calciumMg = alldata.Calcium__mg_;
                var sodiumMg = alldata.Sodium__mg_;
                var phosphorusMg = alldata.Phosphorus__mg_;
                if (calciumMg != null && sodiumMg != null && phosphorusMg!=null)
                    return Json(new object[] {new[] {0, calciumMg.Value}, new[] {1, sodiumMg.Value}, new []{2, phosphorusMg.Value}},
                        JsonRequestBehavior.AllowGet);
            }
            return Json(new[] {new[] {0, 0}, new[] {1, 1}}, JsonRequestBehavior.AllowGet);
        }
    }
}