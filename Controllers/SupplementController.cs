using Microsoft.AspNetCore.Mvc;
using site2024.Models;
using site2024.Repositories.Interfaces;
using site2024.ViewModels;

namespace site2024.Controllers
{
    public class SupplementController : Controller
    {
        private readonly ISupplementRepository _supplementRepository;
        public SupplementController(ISupplementRepository supplementRepository)
        {
            _supplementRepository = supplementRepository;
        }

        public IActionResult List(string category)// url from here
        {
            IEnumerable<Supplement> supplements;
            string categoryProtein = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                supplements = _supplementRepository.Supplements.OrderBy(l => l.SupplementId);
                categoryProtein = "All Supplements";
            }
            else
            {

                supplements = _supplementRepository.Supplements
                     .Where(l => l.Category.CategoryName.Equals(category)).OrderBy(c => c.Name);

                categoryProtein = category;

            }

            var SupplementsListViewModel = new SupplementListViewModel
            {
                Supplements = supplements,
                CategoryProtein = categoryProtein
            };

            return View(SupplementsListViewModel);

        }
        public IActionResult Details(int SupplementId)
        {
            var supplement = _supplementRepository.Supplements.FirstOrDefault(l => l.SupplementId == SupplementId);

            return View(supplement);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Supplement> supplements;
            string categoryProtein = string.Empty;


            if (string.IsNullOrEmpty(searchString))
            {
                supplements = _supplementRepository.Supplements.OrderBy(p => p.SupplementId);
                categoryProtein = "All Supplements";
            }
            else
            {
                supplements = _supplementRepository.Supplements.Where(p => p.Name.ToLower().Contains(searchString.ToLower()));

                if (supplements.Any())

                    categoryProtein = "Supplement";
                else
                    categoryProtein = "Products meeting the search criteria";



            }

            return View("~/Views/Supplement/List.cshtml", new SupplementListViewModel

            {
                Supplements = supplements,
                CategoryProtein = categoryProtein
            });

        }
    }
}
