using Microsoft.AspNetCore.Mvc;
using HttpClientCalls.Models;
namespace HttpClientCalls.Controllers
{
    public class SecureApiCallsController : Controller
    {


        // PostDataModel pObj = new PostDataModel(); //should use DI instead
      private readonly  PostDataModel pObj;

        public SecureApiCallsController(PostDataModel pObjREF)
        {
            this.pObj = pObjREF;
        }

        public IActionResult PostData()
        {
            ViewBag.post = pObj.GetPostData();
            return View();
        }
    }
}
