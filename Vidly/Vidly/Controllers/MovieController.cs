using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {

            var movie = new Movie();

            movie.Name = "Interstellar";
            movie.Id = 13;

            return View(movie);
        }
    }
}