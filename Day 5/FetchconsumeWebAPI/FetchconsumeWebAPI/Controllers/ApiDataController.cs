using Microsoft.AspNetCore.Mvc;

namespace FetchconsumeWebAPI.Controllers
{
    public class ApiDataController : Controller
    {
        public IActionResult PostData()
        {
            return View();
        }
    }
}
