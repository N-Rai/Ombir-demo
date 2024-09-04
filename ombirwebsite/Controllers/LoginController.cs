using Microsoft.AspNetCore.Mvc;

namespace ombirwebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
