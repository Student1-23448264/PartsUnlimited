using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    ///<summary>Line item for the shopping cart.</summary>
    ///<remarks>My second change</remarks>
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}