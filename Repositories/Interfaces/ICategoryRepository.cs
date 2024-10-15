using site2024.Models;

namespace site2024.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories {get;}
    }
}
