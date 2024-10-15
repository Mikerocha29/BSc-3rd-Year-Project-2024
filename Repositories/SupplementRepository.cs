using Microsoft.EntityFrameworkCore;
using site2024.Context;
using site2024.Models;
using site2024.Repositories.Interfaces;

namespace site2024.Repositories
{
    public class SupplementRepository : ISupplementRepository
    {
        private readonly AppDbcontext _context;
        public SupplementRepository(AppDbcontext context)
        {
            _context = context;
                
        }
        public IEnumerable<Supplement> Supplements => _context.Supplements.Include(c => c.Category);

        public IEnumerable<Supplement> SupplementsBestsellers => _context.Supplements.
                                    Where(l => l.Bestsellers)
.Include(c => c.Category);


        public Supplement GetSupplemenById(int supplementId)
        {
            return _context.Supplements.FirstOrDefault(l => l.SupplementId == supplementId);


        }
    }
}
