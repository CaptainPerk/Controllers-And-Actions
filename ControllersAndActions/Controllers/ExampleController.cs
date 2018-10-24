using Microsoft.AspNetCore.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public ViewResult Result() => View(model:"Hello World");

        public RedirectToActionResult Redirect() => RedirectToAction("Index", "Home");

        public JsonResult JsonIndex() => Json(new[] {"Alice", "Bob", "Joe"});

        public ContentResult ContentIndex() => Content("[\"Alice\",\"Bob\",\"Joe\"]", "application/json");

        public ObjectResult ObjectIndex() => Ok(new[] {"Alice", "Bob", "Joe"});

        public VirtualFileResult VirtualFileIndex() => File("/lib/bootstrap/dist/css/bootstrap.css", "text/css");

        public StatusCodeResult StatusCodeIndex() => NotFound();
    }
}
