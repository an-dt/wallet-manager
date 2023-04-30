using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemEnd.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
        public int WalletId { get; set; }
  
        [Range(1000, int.MaxValue)]
        public decimal Amount { get; set; }
  
        public DateTime CreateDate { get; set; } = DateTime.Now;
   
        [StringLength(100, MinimumLength =3)]
        public string? Image { get; set; }
        public bool Income { get; set; } = false;
        [StringLength(100, MinimumLength = 3)]
        public string? Note { get; set; }
        public virtual Category Category { get; set; }
        public virtual Wallet Wallet { get; set; }

    }
}
