using System.ComponentModel.DataAnnotations;

namespace GameSpyTelegram.DB.Model
{
    public class PlayerInGameGroup
    {
        [Key]
        public int Id { get; set; }
        public int GameGroupId { get; set; }
        public int PlayerId { get; set; }
    }
}
