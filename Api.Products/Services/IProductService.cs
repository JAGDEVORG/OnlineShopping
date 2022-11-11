using Api.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Products.Services
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetProducts();
    }
}
