using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Coffe
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string ClienteName { get; set; }
        [Required]
        public string CoffeType { get; set; }
    }
}
