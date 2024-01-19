using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class SignupController : Controller
    {  
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
