using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cafezinho.Models;

namespace Cafezinho.Controllers
{
    public class CarteirasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarteirasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Carteiras
        public async Task<IActionResult> Index()
        {
              return View(await _context.Carteira.ToListAsync());
        }

        // GET: Carteiras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Carteira == null)
            {
                return NotFound();
            }

            var carteira = await _context.Carteira
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        // GET: Carteiras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carteiras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,valorTotalCarteira")] Carteira carteira)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carteira);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carteira);
        }

        // GET: Carteiras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Carteira == null)
            {
                return NotFound();
            }

            var carteira = await _context.Carteira.FindAsync(id);
            if (carteira == null)
            {
                return NotFound();
            }
            return View(carteira);
        }

        // POST: Carteiras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,valorTotalCarteira")] Carteira carteira)
        {
            if (id != carteira.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carteira);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarteiraExists(carteira.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carteira);
        }

        // GET: Carteiras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Carteira == null)
            {
                return NotFound();
            }

            var carteira = await _context.Carteira
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carteira == null)
            {
                return NotFound();
            }

            return View(carteira);
        }

        // POST: Carteiras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Carteira == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Carteira'  is null.");
            }
            var carteira = await _context.Carteira.FindAsync(id);
            if (carteira != null)
            {
                _context.Carteira.Remove(carteira);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarteiraExists(int id)
        {
          return _context.Carteira.Any(e => e.Id == id);
        }
    }
}
