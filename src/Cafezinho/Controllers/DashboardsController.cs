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
    public class DashboardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dashboards
        public async Task<IActionResult> Index()
        {
              return View(await _context.Dashboard.ToListAsync());
        }

        // GET: Dashboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Dashboard == null)
            {
                return NotFound();
            }

            var dashboard = await _context.Dashboard
                .FirstOrDefaultAsync(m => m.DashboardId == id);
            if (dashboard == null)
            {
                return NotFound();
            }

            return View(dashboard);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DashboardId,TotalEmCarteira")] Dashboard dashboard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dashboard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dashboard);
        }

        // GET: Dashboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Dashboard == null)
            {
                return NotFound();
            }

            var dashboard = await _context.Dashboard.FindAsync(id);
            if (dashboard == null)
            {
                return NotFound();
            }
            return View(dashboard);
        }

        // POST: Dashboards/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DashboardId,TotalEmCarteira")] Dashboard dashboard)
        {
            if (id != dashboard.DashboardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dashboard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DashboardExists(dashboard.DashboardId))
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
            return View(dashboard);
        }

        // GET: Dashboards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Dashboard == null)
            {
                return NotFound();
            }

            var dashboard = await _context.Dashboard
                .FirstOrDefaultAsync(m => m.DashboardId == id);
            if (dashboard == null)
            {
                return NotFound();
            }
            

            return View(dashboard);
        }

        // POST: Dashboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Dashboard == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Dashboard'  is null.");
            }
            var dashboard = await _context.Dashboard.FindAsync(id);
            if (dashboard != null)
            {
                _context.Dashboard.Remove(dashboard);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DashboardExists(int id)
        {
          return _context.Dashboard.Any(e => e.DashboardId == id);
        }
    }
}
