using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_MVC_Demo.Controllers.Test
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}