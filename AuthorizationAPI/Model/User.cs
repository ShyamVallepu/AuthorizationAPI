using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationAPI.Model
{
    public class User
    {

        [Required]
        [Key]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
