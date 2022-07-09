using lolPlay.Data.Models;

namespace lolPlay.Data.Interfaces
{
    public interface ICatalogBranches
    {
        IEnumerable<CatalogBranch> GetBranches();
    }
}
