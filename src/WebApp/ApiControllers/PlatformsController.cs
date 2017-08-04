using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.AspNetCore.Cors;
using WebApp.Data;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    public class PlatformsController : Controller
    {
        private Context _context = null;

        public PlatformsController(Context context)
        {
            _context = context;   
        }

        [HttpGet]
        public IActionResult Get()
        {
            var platforms = _context.Platforms
                .OrderBy(p => p.Name)
                .ToList();

            // HTTP Status Code 200
            return Ok(platforms);
        }
    }
}
