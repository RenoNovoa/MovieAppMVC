using Microsoft.AspNetCore.Mvc;
using MovieAppSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppSearch.Controllers
{
    public class MovieController : Controller
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Title = "Thunder Runnig", Genre ="Sport & Fitness"},
            new Movie { Title = "Sonic the Hedgehog", Genre="Comedy"},
            new Movie { Title = "Coco",  Genre = "Comedy"},
            new Movie { Title = "The LEGO Movie",Genre = "Kids & Family"},
            new Movie { Title = "Drag Me to Hell", Genre = "Horror"},
            new Movie { Title = "La Llorona", Genre ="Horror"},
            new Movie { Title = "Black Panther", Genre ="Scifi"},
            new Movie { Title = "Avengers ", Genre ="Scifi"},
            new Movie { Title = "Spider Man", Genre = "Scifi"},
            new Movie { Title = "Born To Run", Genre ="Drama"},
            new Movie { Title = "Lady Bird", Genre ="Drama"},
            new Movie { Title = "The GodFather", Genre ="Drama"},
            new Movie { Title = "Singing in the Rain", Genre = "Romance"},
            new Movie { Title = "A Nigth at the Opera", Genre = "Romance"},
            new Movie { Title = "Beauty and the Beast", Genre = "Romance"}
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
        public IActionResult SearchResultGenre(string genre)
        {
            var movies = _movies.Where(_ => _.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
            return View(movies);
        }

        public IActionResult SearchResultTitle(string title)
        {
            var movies = _movies.Where(_ => _.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            return View(movies);
        }
    }
}
