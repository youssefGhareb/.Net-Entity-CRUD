using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorPages.Data;
using razorPages.Data.Models;
using razorPages.Services;

namespace razorPages.Pages
{
    public class MovieModel : PageModel
    {
        public MovieModel(IMoviesService service)
        {
            _service = service;
        }
        private IMoviesService _service;
        public Movie? movie { get; set; }
        public void OnGet(int id)
        {
            movie = _service.GetMovie(id);
        }
    }
}
