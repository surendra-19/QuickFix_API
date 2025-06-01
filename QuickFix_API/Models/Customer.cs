using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix_API.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; } = "";
        
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; } = "";

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; } = "";

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Password { get; set; } = "";

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CityLivingIn { get; set; } = "";

    }
}
