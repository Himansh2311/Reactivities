using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    //DataContext file should derived from / implement DBContext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
    }
}