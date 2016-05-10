using System.Linq;
using System.Web.Mvc;


    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Index()
        {
            var data = new Data();            
            return PartialView("_Navbar", data.navbarItems().ToList());
        }
    }
