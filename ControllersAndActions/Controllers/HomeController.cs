using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("SimpleForm");
        
        [HttpPost]
        public RedirectToActionResult ReceiveForm(string name, string city) => RedirectToAction(nameof(Data));

        public ViewResult Data() => View("Result");
    }
}