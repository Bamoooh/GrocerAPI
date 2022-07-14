using System;
using System.ComponentModel.DataAnnotations;
namespace GrocerAPI.Models
{
    public class Market
    {
        [Required]
        public int MarketId { get; set; }
        [Required]
        public string MarketName { get; set; }
        public int FamilyId { get; set; }
        public List<Grocery> Groceries { get; set; }
    }

}