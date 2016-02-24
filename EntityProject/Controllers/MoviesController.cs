using EntityProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityProject.Controllers {
    public class MoviesController : Controller {
        private DataContext _db = new DataContext();

        // GET: Movies
        public ActionResult Index() {
            var movies = (from m in _db.Movies.Include(m => m.Actors)
                          select m).ToList();

            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int id) {
            return View((from m in _db.Movies
                         where m.Id == id
                         select m).FirstOrDefault());
        }

        // GET: Movies/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(Movie movie) {

            if (ModelState.IsValid) {

                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id) {
            return View((from m in _db.Movies
                         where m.Id == id
                         select m).FirstOrDefault());
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Movie movie) {

            if (ModelState.IsValid) {

                var dbMovie = (from m in _db.Movies
                               where m.Id == id
                               select m).FirstOrDefault();
                dbMovie.Title = movie.Title;
                dbMovie.Director = movie.Director;
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id) {
            return View((from m in _db.Movies
                         where m.Id == id
                         select m).FirstOrDefault());
        }

        // POST: Movies/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ActuallyDelete(int id) {

            _db.Movies.Remove((from m in _db.Movies
                               where m.Id == id
                               select m).FirstOrDefault());
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
