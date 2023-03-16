using Microsoft.AspNetCore.Mvc;

namespace shooppingMVC.Controllers
{
    public class APICallsController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
