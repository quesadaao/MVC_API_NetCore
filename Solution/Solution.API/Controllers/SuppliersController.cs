using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using data = Solution.DO.Objects;
using Solution.BS;
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


    }
}