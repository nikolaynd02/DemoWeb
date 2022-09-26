using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Data.Models
{
    public class PhoneNumberPost
    {
        public PhoneNumberPost()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int PostedBy { get; set; }

        public string Description { get; set; }

        public string Interests { get; set; }

        public virtual ICollection<User> Users { get; set; }


    }
}
