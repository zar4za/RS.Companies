using Microsoft.AspNetCore.Mvc;

namespace RS.Companies.Features.Pages
{
    public class CompaniesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
