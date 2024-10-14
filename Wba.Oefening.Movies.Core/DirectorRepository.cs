using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.Oefening.Movies.Core
{
    public class DirectorRepository
    {
        private static List<Director> Directors = new List<Director>
        {
            new Director{Id=1,FirstName="Steven",SurName="Spielberg" },
            new Director{Id=2,FirstName="George", SurName="Lucas" },
            new Director{Id=3,FirstName="Martin",SurName="Scorsese" },
            new Director{Id=4,FirstName="Quentin",SurName="Tarantino" }
        };
        

        public IEnumerable<Director> GetDirectors()
        {
            return Directors;
        }
    }


}
