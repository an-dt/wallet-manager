
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemEnd.Models
{
    public class UserInfor
    {
        [StringLength(450)]
        [Key] 
        public string? Id { get; set; }
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Image { get; set; }
   


        [ForeignKey("UserId")]
        public virtual IdentityUser? User { get; set; }

    }
}
