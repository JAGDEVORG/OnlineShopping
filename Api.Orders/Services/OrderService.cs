using Api.Orders.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Api.Users.Services
{
    public class OrderService : IOrderService
    {
        public Task<List<OrderModel>> GetOrderByUserId(int userId)
        {
            List<OrderModel> orders = new List<OrderModel>();
            var o1 = new OrderModel
            {
                Id = 11001,
                ProductCode = "AP01",
                Quantity = 1,
                Price = 20,
                TotalPrice = 20,
                UserId = 1001,
                OrderDate = DateTime.Now
            };
            var o2 = new OrderModel
            {
                Id = 11002,
                ProductCode = "BP02",
                Quantity = 3,
                Price = 25,
                TotalPrice = 75,
                UserId = 1001,
                OrderDate = DateTime.Now
            };
            var o3 = new OrderModel
            {
                Id = 11003,
                ProductCode = "CP03",
                Quantity = 3,
                Price = 30,
                TotalPrice = 90,
                UserId = 1001,
                OrderDate = DateTime.Now
            };
            var o4 = new OrderModel
            {
                Id = 11004,
                ProductCode = "AP01",
                Quantity = 2,
                Price = 40,
                TotalPrice = 80,
                UserId = 1002,
                OrderDate = DateTime.Now
            };
            var o5 = new OrderModel
            {
                Id = 11005,
                ProductCode = "BP02",
                Quantity = 1,
                Price = 20,
                TotalPrice = 20,
                UserId = 1002,
                OrderDate = DateTime.Now
            };
            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);
            orders.Add(o5);

            var result = orders.Where(x => x.UserId == userId).ToList();

            return Task.FromResult(result);
        }
    }
}
