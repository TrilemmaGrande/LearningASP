using System.Linq;

namespace Beispiel.Sportsstore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext ctx;
        public EFStoreRepository(StoreDbContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products => ctx.Products;
    }
}
