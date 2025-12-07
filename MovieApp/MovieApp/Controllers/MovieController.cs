using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieAppContext db;

        public MovieController(MovieAppContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        public IActionResult Edit(int movieid)
        {
            Movie movie = db.Movies.Where(m => m.MovieId == movieid).FirstOrDefault();
            return View(movie);
        }

        public IActionResult Save(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                {
                    db.Movies.Add(movie);
                }
                else
                {
                    Movie m = db.Movies.FirstOrDefault(m => m.MovieId == movie.MovieId);
                    if (m != null)
                    {  
                        m.Name = movie.Name;
                        m.Year = movie.Year;
                        m.Rating = movie.Rating;
                        m.Genre = movie.Genre;
                    }
                }
                db.SaveChanges();
                TempData["message"] = $"{movie.Name} was saved";

                return RedirectToAction("Edit", movie);
            }
            else
            {
                return View("Edit", movie);
            }
        }
        public IActionResult Add()
        {
            return View("Edit", new Movie());
        }

        public IActionResult Delete(int mid)
        {
            Movie m = db.Movies.Find(mid);
            db.Movies.Remove(m);
            db.SaveChanges();
            TempData["message"] = $"{m.Name} was deleted";

            return RedirectToAction("Index");
        }

    }
}
