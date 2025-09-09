using GameSpyTelegram.DB.GameSpy;
using GameSpyTelegram.DB.Model;
using GameSpyTelegram.DB.Repositories.Interfaces;

namespace GameSpyTelegram.DB.Repositories
{
	public sealed class PlayerRepository: IPlayerRepository
	{
        private readonly GameSpyContext _context;

        public PlayerRepository(GameSpyContext context)
        {
            _context = context;
        }

        public async Task AddPlayer(Player player)
		{
			await _context.AddAsync(player);
			await _context.SaveChangesAsync();
		}
	}
}
