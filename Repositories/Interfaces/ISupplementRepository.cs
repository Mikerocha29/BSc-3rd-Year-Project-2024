using site2024.Models;

namespace site2024.Repositories.Interfaces
{
    public interface ISupplementRepository
    {
        IEnumerable<Supplement> Supplements { get; }
        IEnumerable<Supplement> SupplementsBestsellers { get; }

        Supplement GetSupplemenById(int supplementId);

    }
}
