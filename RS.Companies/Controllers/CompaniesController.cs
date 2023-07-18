using Microsoft.AspNetCore.Mvc;

namespace RS.Companies.Controllers
{
    public class CompaniesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
