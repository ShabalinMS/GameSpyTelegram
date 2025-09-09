using Microsoft.EntityFrameworkCore;

namespace GameSpyTelegram.DB.GameSpy
{
    /// <summary>
    /// 
    /// </summary>
    public class GameSpyContext: DbContext
    {
        public DbSet<Player> Players { get; set; }

        public GameSpyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=GameSpyDev;Username=postgres;Password=postgres");
        }

    }
}
