using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPages.Data;
using razorPages.Data.Models;
using razorPages.Services;

namespace razorPages.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public int Rate { get; set; }
        [BindProperty]
        public string Description { get; set; }
        public AddMovieModel(IMoviesService service)
        {
            _service = service;
        }
        private IMoviesService _service;

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _ = $"{Title} -- {Rate} -- {Description}";
            if(ModelState.IsValid)
            {
                var movie = new Movie() {
                Title= Title,
                Rate = Rate,
                Description = Description
                };
                _service.AddMovie(movie);
                return Redirect("Movies");
            }
            return Page();
        }
    }
}
