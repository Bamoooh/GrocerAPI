using System;
using System.ComponentModel.DataAnnotations;

namespace GrocerAPI.Models
{
    public class Grocery
    {
        [Required]
        public int GroceryId { get; set; }
        [Required]
        public string GroceryName { get; set; }
        [Required]
        public int Count { get; set; }
        public int MarketId { get; set; }
    }
}