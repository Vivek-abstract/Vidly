using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Harry Potter" };

            return View(movie);

        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //movies
        public ActionResult Index(int? pageIndex=1, string sortBy="Name")
        {
            return Content(String.Format("pageIndex={0} and sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
    }
}