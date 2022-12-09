using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPages.Data.Models;
using razorPages.Services;

namespace razorPages.Pages
{
    public class DeleteMovieModel : PageModel
    {
        [BindProperty]
        public Movie? Movie { get; set; }
        private IMoviesService _service;
        public DeleteMovieModel(IMoviesService service)
        {
            _service = service;
        }
        public void OnGet(int id)
        {
            Movie = _service.GetMovie(id);
        }
        public IActionResult OnPost()
        {
            _service.DeleteMovie(Movie.Id);
            return Redirect("../movies");
        }
    }
}
