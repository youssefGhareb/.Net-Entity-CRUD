using razorPages.Data;
using razorPages.Data.Models;
using System.Reflection.Metadata.Ecma335;

namespace razorPages.Services
{
    public class MoviesService : IMoviesService
    {
        public MoviesService(ApplicationDbContext context)
        {
            _context= context;
        }

        private ApplicationDbContext _context;
        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie? movie)
        {
            if(movie != null)
            {
                var result = _context.Movies.FirstOrDefault(m => m.Id == movie.Id);
                if(result != null)
                {
                    result.Title = movie.Title;
                    result.Description = movie.Description;
                    result.Rate = movie.Rate;
                    _context.SaveChanges();
                }
            }
        }

        public void DeleteMovie(int id)
        {
            if(id != 0)
            {
                var result = _context.Movies.Single(m => m.Id == id);
                _context.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Movie> GetAll() => _context.Movies.ToList();

        public Movie? GetMovie(int id) => _context.Movies.FirstOrDefault(x => x.Id == id);
    }
}
