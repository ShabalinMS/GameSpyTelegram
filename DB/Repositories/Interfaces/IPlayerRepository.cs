using GameSpyTelegram.DB.Model;

namespace GameSpyTelegram.DB.Repositories.Interfaces
{
    public interface IPlayerRepository
    {
        public Task AddPlayer(Player player);
    }
}
