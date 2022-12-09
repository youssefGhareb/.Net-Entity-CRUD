using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPages.Data.Models;
using razorPages.Services;

namespace razorPages.Pages
{
    public class EditMovieModel : PageModel
    {
        [BindProperty]
        public Movie? movie { get; set; }
        public EditMovieModel(IMoviesService service)
        {
            _service= service;
        }
        private IMoviesService _service;
        public void OnGet(int id)
        {
            movie = _service.GetMovie(id);
        }
        public IActionResult OnPost()
        {
            _service.EditMovie(movie);
            return Redirect("../Movies");
        }
    }
}
