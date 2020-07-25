using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using data = Solution.DO.Objects;
using bussiness = Solution.BS;
using Solution.DAL.EF;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly SolutionDBContext _context;

        public CategoriesController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Categories>>> GetCategories()
        {
            return new bussiness.Categories(_context).GetAll().ToList();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Categories>> GetCategories(int id)
        {
            var Categories = new bussiness.Categories(_context).GetOneById(id);

            if (Categories == null)
            {
                return NotFound();
            }

            return Categories;
        }

        // PUT: api/Categories
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategories(int id, data.Categories Categories)
        {
            if (id != Categories.CategoryId)
            {
                return BadRequest();
            }


            try
            {
                new bussiness.Categories(_context).Updated(Categories);
            }
            catch (Exception ee)
            {
                throw ee;
            }

            return NoContent();
        }

        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<data.Categories>> PostCategories(data.Categories Categories)
        {
            new bussiness.Categories(_context).Insert(Categories);
            return CreatedAtAction("GetCategories", new { id = Categories.CategoryId }, Categories);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Categories>> DeleteCategories(int id)
        {
            var Categories = new bussiness.Categories(_context).GetOneById(id);
            if (Categories == null)
            {
                return NotFound();
            }

            new bussiness.Categories(_context).Delete(Categories);

            return Categories;
        }

    }
}