using Microsoft.AspNetCore.Mvc;
using site2024.Models;
using site2024.Repositories.Interfaces;
using site2024.ViewModels;
using System.Diagnostics;

namespace site2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISupplementRepository _supplementRepository;

        public HomeController(ISupplementRepository supplementRepository)
        {
            _supplementRepository = supplementRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                SupplementsBestsellers = _supplementRepository.SupplementsBestsellers

            };
            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
