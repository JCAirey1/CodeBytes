using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class TokenController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewToken()
        {
            return View();
        }

    }
}
