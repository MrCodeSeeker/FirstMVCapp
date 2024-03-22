using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        [Route("api/HelloWorld/Index")]
        public IActionResult Index()
        {
            DogViewModel dg = new DogViewModel() { Name = "Bishop", Age = 11 };
            return View(dg);
        }
        public string dog()
        { return "Who's there"; }
        public IActionResult create()
        {
            return View();  
        }
    }
}
