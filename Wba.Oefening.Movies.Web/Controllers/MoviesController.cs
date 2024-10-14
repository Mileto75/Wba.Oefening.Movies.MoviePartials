using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Core;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieRepository _movieRepository;
        public MoviesController()
        {
            _movieRepository = new MovieRepository();
        }
        public IActionResult Index()
        {
            //get the movies
            var movies = _movieRepository.GetMovies();
            //fill the model
            var moviesIndexViewModel = new MoviesIndexViewModel();
            moviesIndexViewModel.Movies = movies
                .Select(m => new BaseViewModel
                {
                    Id = m.Id,
                    Value = m.Title,
                    Image = m.Image,
                });
            //pass to the view
            return View(moviesIndexViewModel);
        }
        public IActionResult ShowMovie(int id)
        {
            //get the movie using the id => firstOrDefault
            var movie = _movieRepository
                .GetMovies().FirstOrDefault(m => m.Id == id);
            //check if null
            if(movie == null)
            {
                return NotFound();
            }
            //fill the  => object initializer
            var moviesShowMovieViewModel = new MoviesShowMovieViewModel
            {
                Id = movie.Id,
                Value = movie.Title,
                Image = movie.Image,
                Genre = new BaseViewModel
                {
                    Id = movie.Genre.Id,
                    Value = movie.Genre.Name,
                },
                Actors = movie.Actors.Select(a => new BaseViewModel
                {
                    Id = a.Id,
                    Value = $"{a.FirstName} {a.SurName}"
                }),
                Directors = movie.Directors.Select(a => new BaseViewModel
                {
                    Id = a.Id,
                    Value = $"{a.FirstName} {a.SurName}"
                }),
            };

            //pass to the view
            return View(moviesShowMovieViewModel);
        }
    }
}
