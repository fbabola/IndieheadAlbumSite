using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicAlbumSite.Models; 

namespace MusicAlbumSite.Controllers
{
    public class ArtistsController : Controller
    {
        // GET: Artists
        public ActionResult Index()
        {
            var model = new List<Artist>
            {
                new Artist() { Id = 1, Name = "Modest Mouse", YearCreated = 1992},
                new Artist() { Id = 2, Name = "Pink Floyd", YearCreated = 1965}
            };
            return View(model);
        }
    }
}