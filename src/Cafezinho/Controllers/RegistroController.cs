using Cafezinho.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cafezinho.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // POST: Registro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRegistro(Registro registro)
        {
            if (ModelState.IsValid)
            {
                registro.setTipoTransacao() = TipoTransacaoEnum.COMPRA;
                decimal valorTotal = registro.getQuantidade() + registro.getPreco();
                _context.Add(registro, valorTotal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registro);
        }
    }
}