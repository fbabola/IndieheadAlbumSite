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
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            };
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            };

            return Content(String.Format($"pageIndex={pageIndex}&sortBy={sortBy}"));
        }

        public ViewResult Random()
        {
            var album = new Album()
            {
                Title = "The Wall",
                Artist = "Pink Floyd"
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