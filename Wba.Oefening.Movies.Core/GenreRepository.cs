using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wba.Oefening.Movies.Core
{
    public class GenreRepository
    {
        //Returns all available Genres
        public IEnumerable<Genre> GetGenres()
        {
            return new Genre[] {
                new Genre{Id=1,Name="Thriller" },
                new Genre{Id=2,Name="Horror" },
                new Genre{Id=3,Name="Comdey" },
                new Genre{Id=4,Name="Drama" },
                new Genre{Id=5,Name="Fantasy" },
            };
        }
    }
}
