using Microsoft.AspNetCore.Mvc;
namespace RazorFun.Controllers
{
    public class RazorFunController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }
    }
}