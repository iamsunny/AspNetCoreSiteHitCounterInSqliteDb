using Microsoft.EntityFrameworkCore;

namespace HitCounter.Models
{

    public class AppStateContext : DbContext
    {
        public AppStateContext (DbContextOptions<AppStateContext> options):base(options)
        {

        }

        public DbSet<AppState> AppStates { get; set; }

    }

}