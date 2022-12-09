using razorPages.Data.Models;

namespace razorPages.Services
{
    public interface IMoviesService
    {
        List<Movie> GetAll();
        Movie? GetMovie(int id);
        void EditMovie(Movie movie);
        void DeleteMovie(int id);
        void AddMovie(Movie movie);
    }
}
