using System;
using System.Collections.Generic;
using Wba.Oefening.Movies.Core;

namespace Wba.Oefening.Movies.Core
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public Genre Genre { get; set; }
        public IEnumerable<Actor> Actors { get; set; }
        public IEnumerable<Director> Directors { get; set; }
    }
}
