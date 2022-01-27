using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeminarManagementSystem.Models;

namespace SeminarManagementSystem.Controllers
{
    public class TypeSeminarController : Controller
    {
        private readonly database _context;

        public TypeSeminarController(database context)
        {
            _context = context;
        }

        // GET: TypeSeminar
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeSeminar.ToListAsync());
        }

        // GET: TypeSeminar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeSeminar = await _context.TypeSeminar
                .FirstOrDefaultAsync(m => m.typeSeminarID == id);
            if (typeSeminar == null)
            {
                return NotFound();
            }

            return View(typeSeminar);
        }

        // GET: TypeSeminar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeSeminar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("typeSeminarID,typeSeminar_Title")] TypeSeminar typeSeminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeSeminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeSeminar);
        }

        // GET: TypeSeminar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeSeminar = await _context.TypeSeminar.FindAsync(id);
            if (typeSeminar == null)
            {
                return NotFound();
            }
            return View(typeSeminar);
        }

        // POST: TypeSeminar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("typeSeminarID,typeSeminar_Title")] TypeSeminar typeSeminar)
        {
            if (id != typeSeminar.typeSeminarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeSeminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeSeminarExists(typeSeminar.typeSeminarID))
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
            return View(typeSeminar);
        }

        // GET: TypeSeminar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeSeminar = await _context.TypeSeminar
                .FirstOrDefaultAsync(m => m.typeSeminarID == id);
            if (typeSeminar == null)
            {
                return NotFound();
            }

            return View(typeSeminar);
        }

        // POST: TypeSeminar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeSeminar = await _context.TypeSeminar.FindAsync(id);
            _context.TypeSeminar.Remove(typeSeminar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeSeminarExists(int id)
        {
            return _context.TypeSeminar.Any(e => e.typeSeminarID == id);
        }
    }
}
