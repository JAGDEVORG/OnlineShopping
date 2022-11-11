using Api.Products.Models;
using Api.Products.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Products.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(IProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }
    [HttpGet]
    public async Task<IEnumerable<ProductModel>> Get()
    {
        return await _productService.GetProducts();
    }

    // GET api/<ProductsController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ProductsController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ProductsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
