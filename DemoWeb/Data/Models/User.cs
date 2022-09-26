using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoWeb.Data.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Interests { get; set; }
        
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [ForeignKey(nameof(PhoneNumberPost))]
        public int PhoneNumberPostId { get; set; }
        public PhoneNumberPost PhoneNumberPost { get; set; }

    }
}
