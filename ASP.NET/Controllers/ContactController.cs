using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult About()                    
        {
            return View();
        }
    }
}
