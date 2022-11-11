using Api.Products.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Api.Products.Services
{
    public class ProductService : IProductService
    {
        public Task<List<ProductModel>> GetProducts()
        {
            var products = new List<ProductModel>();
            var p1 = new ProductModel
            {
                Id = 1,
                Name = "A",
                ProductCode = "AP01"
            };
            var p2 = new ProductModel
            {
                Id = 2,
                Name = "B",
                ProductCode = "BP02"
            };
            var p3 = new ProductModel
            {
                Id = 3,
                Name = "C",
                ProductCode = "CP03"
            };
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            return Task.FromResult(products);
        }
    }
}
