using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollectorBazzarSuficiencia.Data;
using CollectorSuficiencia.Entities;

namespace CollectorBazzarSuficiencia.Controllers
{
    public class SubastasController : Controller
    {
        private readonly CollectorBazzarSuficienciaContext _context;

        public SubastasController(CollectorBazzarSuficienciaContext context)
        {
            _context = context;
        }

        // GET: Subastas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Subasta.ToListAsync());
        }

        // GET: Subastas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subasta = await _context.Subasta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (subasta == null)
            {
                return NotFound();
            }

            return View(subasta);
        }

        // GET: Subastas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subastas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PrecioBase,Puntuacion,Estado,Inicio,Finaliza")] Subasta subasta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subasta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subasta);
        }

        // GET: Subastas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subasta = await _context.Subasta.FindAsync(id);
            if (subasta == null)
            {
                return NotFound();
            }
            return View(subasta);
        }

        // POST: Subastas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PrecioBase,Puntuacion,Estado,Inicio,Finaliza")] Subasta subasta)
        {
            if (id != subasta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subasta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubastaExists(subasta.ID))
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
            return View(subasta);
        }

        // GET: Subastas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subasta = await _context.Subasta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (subasta == null)
            {
                return NotFound();
            }

            return View(subasta);
        }

        // POST: Subastas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subasta = await _context.Subasta.FindAsync(id);
            _context.Subasta.Remove(subasta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubastaExists(int id)
        {
            return _context.Subasta.Any(e => e.ID == id);
        }
    }
}
