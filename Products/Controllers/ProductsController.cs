using System;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Products.Services;

namespace Products.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetAllProducts());
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            var createdProduct = _productService.AddProduct(product);
            return CreatedAtAction(nameof(Get), new { id = createdProduct.Id }, createdProduct);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productService.UpdateProduct(product);
            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_productService.DeleteProduct(id))
            {
                return NoContent();
            }

            return NotFound();
        }
    }

}

