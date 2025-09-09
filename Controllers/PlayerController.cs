using GameSpyTelegram.DB.GameSpy;
using GameSpyTelegram.DB.Model;
using GameSpyTelegram.DB.Repositories;
using GameSpyTelegram.DB.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameSpyTelegram.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlayerController : ControllerBase
	{
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(ILogger<PlayerController> logger, IPlayerRepository playerRepository)
        {
            _logger = logger;
            _playerRepository = playerRepository;
        }

        [HttpGet(Name = "AddPlayer")]
		public async Task Post(int chatId)
		{
			await _playerRepository.AddPlayer(new Player() { ChatId = chatId });
		}
	}
}
