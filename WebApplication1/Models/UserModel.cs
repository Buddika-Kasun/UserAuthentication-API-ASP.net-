using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    [Table("user")]
    public class UserModel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        [Required]
        [StringLength(50)]
        public string fullName { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string mobile { get; set; }
    }

    public class UserLogin
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
