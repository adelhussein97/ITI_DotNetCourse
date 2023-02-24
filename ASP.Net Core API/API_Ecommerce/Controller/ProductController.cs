using Domains;
using ECommerceDbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace API_Ecommerce.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ECommerce_DbContext db;
        public ProductController(ECommerce_DbContext context)
        {
            db=context;
        }

        // localhost:5282/api/Product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                return Ok(db.Products);
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }
           
        }
        // localhost:5282/api/Product
        [HttpGet("{id}")]
        public IActionResult GetAllProductsbyID(int id)
        {
            try
            {
                return Ok(db.Products.Where(p=>p.Id==id));
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }

        }

        [HttpGet("Cat/{Catid}")]
        public IActionResult GetAllProductsbyCategoryID(int Catid)
        {
            try
            {
                return Ok(db.Categories.Where(p => p.Id == Catid).Select(p=>p.Products));
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }

        }



    }
}
