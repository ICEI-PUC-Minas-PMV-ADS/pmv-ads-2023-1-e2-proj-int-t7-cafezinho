
using System.Security.Claims;
using Cafezinho.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            string ClienteCPF = User.Claims.Where((claim) => claim.Type == ClaimTypes.Sid).First().Value;
            List<Registro> todosregistros = await _context.Registros.ToListAsync();
            IEnumerable<Registro> registros = todosregistros.Where((registro) => registro.ClienteId == ClienteCPF);
            return View(registros); 
        }


    }
}