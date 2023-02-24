using ECommerceDbContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Ecommerce.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ECommerce_DbContext db;
        public CategoryController(ECommerce_DbContext context)
        {
            db = context;
        }

        // localhost:5282/api/Product
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            try
            {
                return Ok(db.Categories.Select(c=>new { c.Id,c.Name}));
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }

        }
        // localhost:5282/api/Product
        [HttpGet("{id}")]
        public IActionResult GetAllCategoriesbyID(int id)
        {
            try
            {
                return Ok(db.Categories.Where(p => p.Id == id));
            }
            catch (Exception)
            {
                return BadRequest("Sorry All Data Not Available");
            }

        }
    }
}
