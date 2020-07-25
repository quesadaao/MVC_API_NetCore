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
    public class SuppliersController : Controller
    {
        private readonly SolutionDBContext _context;

        public SuppliersController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Suppliers>>> GetSuppliers()
        {
            return new bussiness.Suppliers(_context).GetAll().ToList();
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Suppliers>> GetSuppliers(int id)
        {
            var suppliers = new bussiness.Suppliers(_context).GetOneById(id);

            if (suppliers == null)
            {
                return NotFound();
            }

            return suppliers;
        }

        // PUT: api/Suppliers
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSuppliers(int id, data.Suppliers suppliers)
        {
            if (id != suppliers.SupplierID)
            {
                return BadRequest();
            }

            
            try
            {
                new bussiness.Suppliers(_context).Updated(suppliers);
            }
            catch (Exception ee)
            {
                    throw ee;
            }

            return NoContent();
        }

        // POST: api/Suppliers
        [HttpPost]
        public async Task<ActionResult<data.Suppliers>> PostSuppliers(data.Suppliers suppliers)
        {
            new bussiness.Suppliers(_context).Insert(suppliers);
            return CreatedAtAction("GetSuppliers", new { id = suppliers.SupplierID }, suppliers);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Suppliers>> DeleteSuppliers(int id)
        {
            var suppliers = new bussiness.Suppliers(_context).GetOneById(id);
            if (suppliers == null)
            {
                return NotFound();
            }

            new bussiness.Suppliers(_context).Delete(suppliers);

            return suppliers;
        }

    }
}