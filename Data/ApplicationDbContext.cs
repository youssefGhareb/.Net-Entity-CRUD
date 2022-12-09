using Microsoft.EntityFrameworkCore;
using razorPages.Data.Models;
using System.Security.Cryptography.X509Certificates;

namespace razorPages.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }


    }
}
