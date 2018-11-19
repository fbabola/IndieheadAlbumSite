using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicAlbumSite.Models;

namespace MusicAlbumSite.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var model = new List<Album>
            {
                new Album() { Id = 1, Title = "The Wall", Artist = new Artist() { Name = "Pink Floyd"}},
                new Album() { Id = 2, Title = "The Lonesome Crowded West", Artist = new Artist() {Name = "Modest Mouse"}}
            };
            return View(model);
        }

        public ViewResult Random()
        {
            var album = new Album()
            {
                Title = "The Wall",
                Artist = new Artist { Name = "Pink Floyd", YearCreated = 1960 }
            };
            return View(album);
        }

        [Route("movies/releasedIn/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }
    }
}