using System.Web.Mvc;

namespace FrontArchitectureLab.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index(string countryCode)
        {
            if (!string.IsNullOrWhiteSpace(countryCode))
                ViewBag.CountryCode = countryCode;

            return View();
        }
    }
}