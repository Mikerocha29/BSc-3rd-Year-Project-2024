using Microsoft.EntityFrameworkCore;
using site2024.Context;

namespace site2024.Models
{
    public class ShoppingCart
    {
        private readonly AppDbcontext _context;

        public ShoppingCart(AppDbcontext context)
        {
            _context = context;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)// SP
        {
            // define a section
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //
            var context = services.GetService<AppDbcontext>();

            //
            String CartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            //
            session.SetString("CartId", CartId);


            return new ShoppingCart(context)
            {
                ShoppingCartId = CartId

            };


        }

        // method to add  itens to basket.

        public void AddToCart(Supplement supplement)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Supplement.SupplementId == supplement.SupplementId && s.ShoppingCartId == ShoppingCartId);


            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Supplement = supplement,
                    Quantity = 1,
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _context.SaveChanges();

        }

        // method Remove from Basket 

        public void RemoveFromCart(Supplement supplement)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
               s => s.Supplement.SupplementId == supplement.SupplementId && s.ShoppingCartId == ShoppingCartId);

            //var localquantity = 0;

            if (shoppingCartItem != null)// if is diferente the NUll 
            {
                if (shoppingCartItem.Quantity > 1)// eu verifico a quantidade dos intens 
                {
                    shoppingCartItem.Quantity--;
                    // localquantity = ShoppingCartItem.Quantity;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }

            }
            _context.SaveChanges();
            // return localquantity
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Supplement).ToList());

        }

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems.Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);


            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartId ==
            ShoppingCartId).Select(c => c.Supplement.Price * c.Quantity).Sum();

            return total;
        }

        
    }

}
