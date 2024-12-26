using Core_Api.DAL.APIContext;
using Core_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult CategoryLGet(int id)
        {
            var c = new Context();
            var values = c.categories.Find(id);

            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("",p);
        }

        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            var c = new Context();
            var values = c.categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult CategorEdit(Category p)
        {
            var c = new Context();
            var values = c.Find<Category>(p.CategoryId);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                values.CategoryName = p.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return Ok(values);
            }
        }
    }
}
