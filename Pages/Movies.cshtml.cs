using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPages.Data;
using razorPages.Data.Models;
using razorPages.Services;

namespace razorPages.Pages
{
    public class MoviesModel : PageModel
    {
        public MoviesModel(IMoviesService service)
        {
            _service = service;
        }
        private IMoviesService _service;
        public List<Movie> Movies { get; set; }
        public void OnGet()
        {
            Movies = _service.GetAll();
        }
    }
}
