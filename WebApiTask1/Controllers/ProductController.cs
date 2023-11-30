using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using WebApiTask1.Dtos;
using WebApiTask1.Entities;

namespace WebApiTask1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
    //    public static List<Product> Products { get; set; } = new List<Product>
    //    {
    //        new Product
    //        {
    //             Id=1,
    //              ProductName="Lays",
    //               Price=3.95,
    //                Discount=10
    //        },
    //         new Product
    //        {
    //             Id=2,
    //              ProductName="Belocka",
    //               Price=0.95,
    //                Discount=0
    //         },
    //          new Product
    //        {
    //             Id=3,
    //              ProductName="Fanta",
    //               Price=1.0,
    //                Discount=5
    //        },
    //           new Product
    //        {
    //             Id=4,
    //              ProductName="Haribo",
    //               Price=3.5,
    //                Discount=20
    //        },
    //            new Product
    //        {
    //             Id=5,
    //              ProductName="Oreo",
    //               Price=2.9,
    //                Discount=10
    //         },
    //             new Product
    //        {
    //             Id=6,
    //              ProductName="Sirab",
    //               Price=0.4,
    //                Discount=5
    //        }
    //    };

    //    [HttpGet]
    //    public IEnumerable<ProductDto> Get()
    //    {
    //        var dataToReturn = Products.Select(x =>
    //        {
    //            return new ProductDto
    //            {
    //                Id = x.Id,
    //                ProductName = x.ProductName,
    //            };
    //        });
    //        return dataToReturn;
    //    }

        

    //    [HttpGet("{id}")]
    //    public ProductDto Get(int id)
    //    {
    //        var product = Products.FirstOrDefault(x => x.Id == id);
    //        if (product!=null)
    //        {
    //            var dataToReturn = new ProductDto
    //            {
    //                Id = product.Id,
    //                ProductName = product.ProductName,
    //            };
    //            return dataToReturn;
                
    //        }
    //        return null;
    //    }

    //    [HttpPost]
    //    public IActionResult Post([FromBody] ProductAddDto dto)
    //    {
    //        try
    //        {
    //            var product = new Product
    //            {
    //                Id = dto.Id,
    //                ProductName = dto.ProductName,
    //                Price = dto.Price,
    //                Discount= dto.Discount
    //            };
    //            Products.Add(product);
    //            return Ok(product);

    //        }
    //        catch (Exception ex)
    //        {

    //            return BadRequest(ex.Message);
    //        }

    //    }

    //    //[HttpPut("{id")]
    //    //public IActionResult Put(int id, [FromBody] ProductAddDto dto)
    //    //{
    //    //    try
    //    //    {
    //    //        var item = Products.FirstOrDefault(x => x.Id == id);
    //    //        if (item == null)
    //    //        {
    //    //            return NotFound();
    //    //        }
    //    //        item.ProductName = dto.ProductName;
    //    //        item.Price = dto.Price; item.Discount = dto.Discount;
    //    //        return Ok(item);

    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return BadRequest(ex.Message);
    //    //    }
    //    //}


    //    [HttpDelete("{id}")]
    //    public IActionResult Delete(int id)
    //    {
    //        try
    //        {
    //            var item=Products.FirstOrDefault(x => x.Id == id);
    //            if (item==null)
    //            {
    //                return NotFound();
    //            }
    //            Products.Remove(item);
    //            return NoContent();

    //        }
    //        catch (Exception ex)
    //        {

    //            return BadRequest(ex.Message);
    //        }
    //    }



    //    //[HttpDelete("{id}")]
    //    //public IActionResult Delete(int id)
    //    //{
    //    //    try
    //    //    {
    //    //        var item = Players.FirstOrDefault(p => p.Id == id);
    //    //        if (item == null)
    //    //        {
    //    //            return NotFound();
    //    //        }
    //    //        Players.Remove(item);
    //    //        return NoContent();
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return BadRequest(ex.Message);
    //    //    }
    //    //}



    }
}
