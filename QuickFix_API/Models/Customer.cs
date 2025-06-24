using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix_API.Models
{
    public class Customer
    {
        [Key]
        public int Cust_id { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; } = "";
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; } = "";
        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string ContactNumber { get; set; } = "";
        [Column(TypeName = "nvarchar(250)")]
        public string Address { get; set; } = "";
        public int CityLivingIn { get; set; }
    }
}
