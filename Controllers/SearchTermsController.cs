using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcSearch.Controllers
{
    public class SearchTermsController : Controller
    {
        //
        // GET: /SearchTerms
        public IActionResult Index()
        {
            return View();
        }
    }
}