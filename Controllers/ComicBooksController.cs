using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
         public ActionResult Detail ()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man!";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final alieudghiadefhgiuaefgiurefhiguher</p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"

            };



            return View();
        }
    }
}   



