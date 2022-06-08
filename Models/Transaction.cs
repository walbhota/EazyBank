using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyBank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [DisplayName("Account Number")]
        [Column(TypeName ="nvarchar(12)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(12,ErrorMessage ="Max characters for this field is 12")]
        public string AccountNumber { get; set; }
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(135)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(135)]
        public string BeneficiaryName { get; set; }
        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(135)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(135)]
        public string BankName { get; set; }
        [DisplayName("Bank Swift Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11,ErrorMessage ="Max character for this field is 11")]
        public string SWIFTCode { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
