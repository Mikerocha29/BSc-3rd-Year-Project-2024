using site2024.Context;
using site2024.Models;
using site2024.Repositories.Interfaces;

namespace site2024.Repositories
{
    public class OrderRepository : IOrderRepository

    {
        private readonly AppDbcontext _appDbcontext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbcontext appDbcontext, ShoppingCart shoppingCart)
        {
            _appDbcontext = appDbcontext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderSent = DateTime.Now;
            _appDbcontext.Orders.Add(order);
            _appDbcontext.SaveChanges();

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach (var cartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Quantity = cartItem.Quantity,
                    SupplementId = cartItem.Supplement.SupplementId,
                    OrderId = order.OrderId,
                    Price = cartItem.Supplement.Price,
                };
                _appDbcontext.OrderDetails.Add(orderDetail);
            }
            _appDbcontext.SaveChanges();
        }
    }
}

