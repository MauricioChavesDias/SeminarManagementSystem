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
    public class SeminarController : Controller
    {
        private readonly database _context;

        public SeminarController(database context)
        {
            _context = context;
        }

        // GET: Seminar
        public async Task<IActionResult> Index()
        {
            var database = _context.Seminar.Include(s => s.organiser).Include(s => s.typeSeminar);
            return View(await database.ToListAsync());
        }

        // GET: Seminar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar
                .Include(s => s.organiser)
                .Include(s => s.typeSeminar)
                .FirstOrDefaultAsync(m => m.seminarID == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // GET: Seminar/Create
        public IActionResult Create()
        {
            ViewData["organiserID"] = new SelectList(_context.Organiser, "organiserID", "organiser_name");
            ViewData["typeSeminarID"] = new SelectList(_context.TypeSeminar, "typeSeminarID", "typeSeminar_Title");
            return View();
        }

        // POST: Seminar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("seminarID,organiserID,typeSeminarID,seminar_title,seminar_description")] Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["organiserID"] = new SelectList(_context.Organiser, "organiserID", "organiser_name", seminar.organiserID);
            ViewData["typeSeminarID"] = new SelectList(_context.TypeSeminar, "typeSeminarID", "typeSeminar_Title", seminar.typeSeminarID);
            return View(seminar);
        }

        // GET: Seminar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar.FindAsync(id);
            if (seminar == null)
            {
                return NotFound();
            }
            ViewData["organiserID"] = new SelectList(_context.Organiser, "organiserID", "organiser_name", seminar.organiserID);
            ViewData["typeSeminarID"] = new SelectList(_context.TypeSeminar, "typeSeminarID", "typeSeminar_Title", seminar.typeSeminarID);
            return View(seminar);
        }

        // POST: Seminar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("seminarID,organiserID,typeSeminarID,seminar_title,seminar_description")] Seminar seminar)
        {
            if (id != seminar.seminarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeminarExists(seminar.seminarID))
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
            ViewData["organiserID"] = new SelectList(_context.Organiser, "organiserID", "organiser_name", seminar.organiserID);
            ViewData["typeSeminarID"] = new SelectList(_context.TypeSeminar, "typeSeminarID", "typeSeminar_Title", seminar.typeSeminarID);
            return View(seminar);
        }

        // GET: Seminar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminar
                .Include(s => s.organiser)
                .Include(s => s.typeSeminar)
                .FirstOrDefaultAsync(m => m.seminarID == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // POST: Seminar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminar.FindAsync(id);
            _context.Seminar.Remove(seminar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeminarExists(int id)
        {
            return _context.Seminar.Any(e => e.seminarID == id);
        }
    }
}
