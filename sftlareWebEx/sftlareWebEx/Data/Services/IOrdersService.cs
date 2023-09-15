using sftlareWebEx.Data.Cart;
using sftlareWebEx.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace sftlareWebEx.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> item, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
