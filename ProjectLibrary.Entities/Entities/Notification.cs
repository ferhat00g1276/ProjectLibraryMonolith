using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjectLibrary.Server.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string Message { get; set; }

       
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
