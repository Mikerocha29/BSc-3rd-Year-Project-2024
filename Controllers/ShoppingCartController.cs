using Microsoft.AspNetCore.Mvc;
using site2024.Models;
using site2024.Repositories.Interfaces;
using site2024.ViewModels;

namespace site2024.Controllers
{
    public class ShoppingCartController : Controller
    {

        // injet a intance from repositore suplement 

        private readonly ISupplementRepository _supplementRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISupplementRepository supplementRepository, ShoppingCart shoppingCart)
        {
            _supplementRepository = supplementRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };

            return View(shoppingCartVM);
        }
        public RedirectToActionResult AddItemCart(int SupplementId)
        {
            var Selectedsupplement = _supplementRepository.Supplements.FirstOrDefault(p=> p.SupplementId == SupplementId);

            if (Selectedsupplement != null)
            {
                _shoppingCart.AddToCart(Selectedsupplement);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveItemFromShoppingCart(int SupplementId)
        {
            var Selectedsupplement = _supplementRepository.Supplements.FirstOrDefault(p => p.SupplementId == SupplementId);

            if (Selectedsupplement != null)
            {
                _shoppingCart.RemoveFromCart(Selectedsupplement);
            }
            return RedirectToAction("Index");

        }
    }
}
