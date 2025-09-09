using GameSpyTelegram.DB.Model;
using Microsoft.EntityFrameworkCore;

namespace GameSpyTelegram.DB.GameSpy
{
    public class GameSpyContext : DbContext
    {
        public GameSpyContext(DbContextOptions<GameSpyContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<GameGroup> GameGroups { get; set; }
        public DbSet<PlayerInGameGroup> PlayerInGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}