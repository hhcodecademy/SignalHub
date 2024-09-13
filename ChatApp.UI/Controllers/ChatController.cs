using Microsoft.AspNetCore.Mvc;

namespace ChatApp.UI.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
