using System.ComponentModel.DataAnnotations;

namespace GameSpyTelegram.DB.Model
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public int ChatId { get; set; }

    }
}
