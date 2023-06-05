using System.Linq;

namespace Beispiel.Sportsstore.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get;  }
        void SaveOrder(Order order);
    }
}
