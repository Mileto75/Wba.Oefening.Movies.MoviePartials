using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.Oefening.Movies.Core
{
    public class ActorRepository
    {
        private static Actor[] Actors = 
        {
            new Actor{Id=1,FirstName="Brad",SurName="Pitt"},
            new Actor{Id=2,FirstName="Robert",SurName="De Niro"},
            new Actor{Id=3,FirstName="Walter",SurName="Capiau"},
            new Actor{Id=4,FirstName="Angelina",SurName="Jolie"},
            new Actor{Id=5,FirstName="John",SurName="Travolta"},
            new Actor{Id=6,FirstName="Samuel",SurName="Jackson"},
            new Actor{Id=7,FirstName="Bruce",SurName="Willis"},
        };

        public IEnumerable<Actor> GetActors()
        {
            return Actors;
        }
    }
}
