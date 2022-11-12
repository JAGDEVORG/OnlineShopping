using Api.Orders.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Users.Services
{
    public interface IOrderService
    {
        public Task<List<OrderModel>> GetOrderByUserId(int userId);
    }
}
