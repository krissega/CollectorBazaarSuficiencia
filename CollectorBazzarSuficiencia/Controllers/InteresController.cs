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
    public class InteresController : Controller
    {
        private readonly CollectorBazzarSuficienciaContext _context;

        public InteresController(CollectorBazzarSuficienciaContext context)
        {
            _context = context;
        }

        // GET: Interes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Interes.ToListAsync());
        }

        // GET: Interes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interes = await _context.Interes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (interes == null)
            {
                return NotFound();
            }

            return View(interes);
        }

        // GET: Interes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Interes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Descipcion")] Interes interes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interes);
        }

        // GET: Interes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interes = await _context.Interes.FindAsync(id);
            if (interes == null)
            {
                return NotFound();
            }
            return View(interes);
        }

        // POST: Interes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Descipcion")] Interes interes)
        {
            if (id != interes.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InteresExists(interes.ID))
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
            return View(interes);
        }

        // GET: Interes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interes = await _context.Interes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (interes == null)
            {
                return NotFound();
            }

            return View(interes);
        }

        // POST: Interes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interes = await _context.Interes.FindAsync(id);
            _context.Interes.Remove(interes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InteresExists(int id)
        {
            return _context.Interes.Any(e => e.ID == id);
        }
    }
}
