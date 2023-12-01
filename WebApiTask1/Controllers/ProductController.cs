using Microsoft.AspNetCore.Mvc;
using WebApiTask1.Services.Abstract;
using WebApiTask1.Dtos;
using WebApiTask1.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet("GetAllProducts")]
        public IEnumerable<ProductDto> GetProducts()
        {
            var items = _productService.GetAll();
            var dataToReturn = items.Select(p =>
            {
                return new ProductDto
                {
                    Name = p.Name,
                    Price = (int)p.Price,
                    Discount = (int)p.Discount
                };
            });
            return dataToReturn;
        }

        // GET api/<ProductController>/5
        [HttpGet("GetProduct")]
        public ProductDto? GetProduct(int id)
        {
            var prod = _productService.Get(id);
            if (prod != null)
            {
                var data = new ProductDto
                {
                    Name = prod.Name,
                    Price = (int)prod.Price,
                    Discount = (int)prod.Discount
                };
                return data;
            }
            return null;
        }

        // POST api/<ProductController>
        [HttpPost("PostProduct")]
        public IActionResult Post([FromBody] ProductDto dto)
        {
            try
            {
                var product = new Product
                {
                    Price = dto.Price,
                    Discount = dto.Discount,
                    Name = dto.Name
                };
                _productService.Add(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("PutProduct")]
        public IActionResult Put(int id, [FromBody] ProductDto dto)
        {
            try
            {
                var item = _productService.Get(id);
                if (item == null)
                {
                    return NotFound();
                }
                item.Price = dto.Price;
                item.Discount = dto.Discount;
                item.Name = dto.Name;
                item.Id = id;
                _productService.Update(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // DELETE api/<ProductController>/5
        [HttpDelete("DeleteProduct")]
        public IActionResult Delete(int id)
        {
            try
            {
                var item = _productService.Get(id);
                if (item == null)
                {
                    return NotFound();
                }
                _productService.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
