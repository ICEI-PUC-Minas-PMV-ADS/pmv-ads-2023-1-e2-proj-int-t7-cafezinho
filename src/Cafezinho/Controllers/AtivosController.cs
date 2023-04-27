using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cafezinho.Models;
using Microsoft.AspNetCore.Authorization;

namespace Cafezinho.Controllers
{
    [Authorize]
    public class AtivosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AtivosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ativos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Ativos.ToListAsync());
        }

        // GET: Ativos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ativos == null)
            {
                return NotFound();
            }

            var ativo = await _context.Ativos
                .FirstOrDefaultAsync(m => m.AtivoId == id);
            if (ativo == null)
            {
                return NotFound();
            }

            return View(ativo);
        }

        // GET: Ativos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ativos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AtivoId,Nome,Ticker,Preco")] Ativo ativo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ativo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ativo);
        }

        // GET: Ativos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ativos == null)
            {
                return NotFound();
            }

            var ativo = await _context.Ativos.FindAsync(id);
            if (ativo == null)
            {
                return NotFound();
            }
            return View(ativo);
        }

        // POST: Ativos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AtivoId,Nome,Ticker,Preco")] Ativo ativo)
        {
            if (id != ativo.AtivoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ativo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtivoExists(ativo.AtivoId))
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
            return View(ativo);
        }

        // GET: Ativos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ativos == null)
            {
                return NotFound();
            }

            var ativo = await _context.Ativos
                .FirstOrDefaultAsync(m => m.AtivoId == id);
            if (ativo == null)
            {
                return NotFound();
            }

            return View(ativo);
        }

        // POST: Ativos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ativos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ativos'  is null.");
            }
            var ativo = await _context.Ativos.FindAsync(id);
            if (ativo != null)
            {
                _context.Ativos.Remove(ativo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtivoExists(int id)
        {
          return _context.Ativos.Any(e => e.AtivoId == id);
        }
    }
}
