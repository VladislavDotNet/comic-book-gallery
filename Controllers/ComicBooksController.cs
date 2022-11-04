using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
         public ActionResult Detail ()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man!",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final что то где то там. типа какой то текст</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"},



                }
            };

            
            return View(comicBook);
        }
    }
}   



