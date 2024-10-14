using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Wba.Oefening.Movies.Core;

namespace Wba.Oefening.Movies.Core
{
    public class MovieRepository
    {
        private readonly DirectorRepository _directorRepository;
        private readonly ActorRepository _actorRepository;
        private readonly GenreRepository _genreRepository;
        private Movie[] movies;

        public MovieRepository()
        {
            _directorRepository = new DirectorRepository();
            _actorRepository = new ActorRepository();
            _genreRepository = new GenreRepository();
            InitMovies();
        }
        private void InitMovies()
        {
            var AllActors = _actorRepository.GetActors();
            var AllDirectors = _directorRepository.GetDirectors();

            //fill the movie array here
            movies = new[]
            {
                new Movie{
                    Id = 1,
                    Title ="It",
                    Directors = AllDirectors.Where(d => d.Id == 1),
                    Actors = AllActors.Where(   a => a.Id == 1 ||
                                                a.Id == 3),
                    Genre = _genreRepository.GetGenres().FirstOrDefault(g => g.Id == 1),
                    Image = "it.jpg"
                },
                new Movie{
                    Id = 2,
                    Title ="Pulp Fiction",
                    Directors = AllDirectors.Where(d => d.Id== 2),
                    Actors = AllActors.Where(   a => a.Id == 2 ||
                                                a.Id == 4),
                    Genre = _genreRepository.GetGenres().FirstOrDefault(g => g.Id == 4),
                    Image = "pulpfiction.jpg"
                },
                new Movie{
                    Id = 3,
                    Title ="Get Shorty",
                    Directors = AllDirectors.Where(d => d.Id == 3),
                    Actors = AllActors.Where(   a => a.Id == 1 ||
                                                a.Id == 5),
                    Genre = _genreRepository.GetGenres().FirstOrDefault(g => g.Id == 3),
                    Image = "getshorty.jpg"
                },
                new Movie{
                    Id = 4,
                    Title ="Star Wars",
                    Directors = AllDirectors.Where(d => d.SurName == "Spielberg"),
                    Actors = AllActors.Where(   a => a.Id == 3 ||
                                                a.Id == 4),
                    Genre = _genreRepository.GetGenres().FirstOrDefault(g => g.Id == 4),
                    Image = "starwars.jpg"
                }
            };
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }
    }
}
