using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemEnd.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
 
        [StringLength(50, MinimumLength =3)]
        public string? Name { get; set; }
        [MaxLength(100)]
 
        public string? Image { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }

    }
}
