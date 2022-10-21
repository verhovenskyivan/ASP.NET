using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()                    
        {
            return View();
        }
    }
}
