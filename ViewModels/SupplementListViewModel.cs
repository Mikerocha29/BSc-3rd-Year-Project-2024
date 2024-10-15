using site2024.Models;

namespace site2024.ViewModels
{
    public class SupplementListViewModel
    {
        public IEnumerable<Supplement> Supplements { get; set; }
        public string CategoryProtein { get; set; }
    }
}
