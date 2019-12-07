﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zelik.Models;
using Zelik.ViewModels;

namespace Zelik.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name= "Shrek!"
            };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer 1"},
                new Customer {Name ="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().Single(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id=1, Name= "John Wick"},
                new Movie{Id=2, Name="Hustlers"}
            };
        }
    }
}