
using System.ComponentModel.DataAnnotations;
namespace TechShop.Models
{
    public class User
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string phone { get; set; }

        [Required]
        public string divstate { get; set; }

        [Required]
        public string town { get; set; }

        [Required]
        public string address { get; set; }
    }
}

