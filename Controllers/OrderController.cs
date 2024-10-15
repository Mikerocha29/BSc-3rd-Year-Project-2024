using Microsoft.AspNetCore.Mvc;
using site2024.Models;
using site2024.Repositories.Interfaces;
using site2024.ViewModels;

namespace site2024.Controllers
{
    public class OrderController : Controller
    {
      private readonly IOrderRepository _orderRepository;
      private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            return View();
        
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            int totalItemsOrdered = 0;
            decimal totalPrice = 0.0m;
            //shopping cart costume 

            List<ShoppingCartItem> items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            // Check if there are any items in the order.
            // 

            if (_shoppingCart.ShoppingCartItems.Count == 0) 
            {
                //It's a collection of name-value pairs that is submitted to the server during the HTTP POST
                ModelState.AddModelError("", "You cart is Empty ");
            }
            // calculate number of items 
            foreach(var item in items)
            {
                totalItemsOrdered += item.Quantity;
                totalPrice += (item.Supplement.Price * item.Quantity);
            }

            // Values obtained from the order.

           order.TotalItemsOrdered = totalItemsOrdered;
           order.TotalOrder = totalPrice;


            // validation order
            if (ModelState.IsValid)
            {
                // create a order details 
                _orderRepository.CreateOrder(order);

                // msg to costumer
                ViewBag.CheckoutCompleteMessage = "Thank You for Order with US :)";
                ViewBag.TotalOrder = _shoppingCart.GetShoppingCartTotal();

                // clear a cart costumer, remove items after buy
                _shoppingCart.ClearCart();

                // didplay the view with customer and order data.
                // 
                return View("~/Views/Order/Completecheckout.cshtml", order);
               


            }
            return View(order);


        }
    }
}
