using System.Linq;

namespace Beispiel.Sportsstore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
