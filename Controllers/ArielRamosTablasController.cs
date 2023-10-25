using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using arielramos_progreso1.Data;
using arielramos_progreso1.Models;

namespace arielramos_progreso1.Controllers
{
    public class ArielRamosTablasController : Controller
    {
        private readonly arielramos_progreso1Context _context;

        public ArielRamosTablasController(arielramos_progreso1Context context)
        {
            _context = context;
        }

        // GET: ArielRamosTablas
        public async Task<IActionResult> Index()
        {
              return _context.ArielRamos_Tabla != null ? 
                          View(await _context.ArielRamos_Tabla.ToListAsync()) :
                          Problem("Entity set 'arielramos_progreso1Context.ArielRamos_Tabla'  is null.");
        }

        // GET: ArielRamosTablas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArielRamos_Tabla == null)
            {
                return NotFound();
            }

            var arielRamos_Tabla = await _context.ArielRamos_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arielRamos_Tabla == null)
            {
                return NotFound();
            }

            return View(arielRamos_Tabla);
        }

        // GET: ArielRamosTablas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArielRamosTablas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArPesoKilogramos,ArAlturaM,ArNombre,ArEmpleado,ArFechaIngreso")] ArielRamos_Tabla arielRamos_Tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arielRamos_Tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arielRamos_Tabla);
        }

        // GET: ArielRamosTablas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArielRamos_Tabla == null)
            {
                return NotFound();
            }

            var arielRamos_Tabla = await _context.ArielRamos_Tabla.FindAsync(id);
            if (arielRamos_Tabla == null)
            {
                return NotFound();
            }
            return View(arielRamos_Tabla);
        }

        // POST: ArielRamosTablas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArPesoKilogramos,ArAlturaM,ArNombre,ArEmpleado,ArFechaIngreso")] ArielRamos_Tabla arielRamos_Tabla)
        {
            if (id != arielRamos_Tabla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arielRamos_Tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArielRamos_TablaExists(arielRamos_Tabla.Id))
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
            return View(arielRamos_Tabla);
        }

        // GET: ArielRamosTablas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArielRamos_Tabla == null)
            {
                return NotFound();
            }

            var arielRamos_Tabla = await _context.ArielRamos_Tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arielRamos_Tabla == null)
            {
                return NotFound();
            }

            return View(arielRamos_Tabla);
        }

        // POST: ArielRamosTablas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArielRamos_Tabla == null)
            {
                return Problem("Entity set 'arielramos_progreso1Context.ArielRamos_Tabla'  is null.");
            }
            var arielRamos_Tabla = await _context.ArielRamos_Tabla.FindAsync(id);
            if (arielRamos_Tabla != null)
            {
                _context.ArielRamos_Tabla.Remove(arielRamos_Tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArielRamos_TablaExists(int id)
        {
          return (_context.ArielRamos_Tabla?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
