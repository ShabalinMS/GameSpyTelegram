using System.ComponentModel.DataAnnotations;

namespace GameSpyTelegram.DB.Model
{
    public class GameGroup
    {
        [Key]
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int Code { get; set; }
    }
}
