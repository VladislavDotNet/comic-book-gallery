using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
         public ActionResult Detail ()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");  
        }
    }
}   



