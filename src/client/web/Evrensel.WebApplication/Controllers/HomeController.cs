using Evrensel.WebApplication.Models;
using Evrensel.WebApplication.Provider;
using Microsoft.AspNetCore.Mvc;

namespace Evrensel.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        ProductProvider provider = new();
        public IActionResult Index()
        {
            string? result = provider.GetAll();
            return View(new IndexModel { Response = result});
        }
    }
}
