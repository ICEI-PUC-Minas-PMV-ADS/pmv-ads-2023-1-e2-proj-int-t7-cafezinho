using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cafezinho.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cafezinho.Controllers
{
    [Route("[controller]")]
    public class Carteira : Controller
    {

        private readonly ApplicationDbContext _context;

        public Carteira (ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Registros.ToListAsync());
        }


    }
}