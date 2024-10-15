using site2024.Context;
using site2024.Models;
using site2024.Repositories.Interfaces;

namespace site2024.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbcontext _context;

        public CategoryRepository(AppDbcontext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
