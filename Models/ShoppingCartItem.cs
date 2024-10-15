using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace site2024.Models
{
   
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Supplement Supplement { get; set; }

        public int Quantity { get; set; }
        [StringLength(300)]
        public string ShoppingCartId { get; set; }
    }
}
