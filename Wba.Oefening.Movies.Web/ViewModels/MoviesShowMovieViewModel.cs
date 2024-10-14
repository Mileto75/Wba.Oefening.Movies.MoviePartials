using Microsoft.Build.Evaluation;

namespace Wba.Oefening.Movies.Web.ViewModels
{
    public class MoviesShowMovieViewModel : BaseViewModel
    {
        public BaseViewModel Genre { get; set; }
        public IEnumerable<BaseViewModel>  Actors { get; set; }
        public IEnumerable<BaseViewModel>  Directors { get; set; }
    }
}
