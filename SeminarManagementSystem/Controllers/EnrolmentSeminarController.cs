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
    public class EnrolmentSeminarController : Controller
    {
        private readonly database _context;

        public EnrolmentSeminarController(database context)
        {
            _context = context;
        }

        // GET: EnrolmentSeminar
        public async Task<IActionResult> Index()
        {
            var database = _context.EnrolmentSeminar.Include(e => e.attendees).Include(e => e.seminar);
            return View(await database.ToListAsync());
        }

        // GET: EnrolmentSeminar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolmentSeminar = await _context.EnrolmentSeminar
                .Include(e => e.attendees)
                .Include(e => e.seminar)
                .FirstOrDefaultAsync(m => m.enrolmentSeminarID == id);
            if (enrolmentSeminar == null)
            {
                return NotFound();
            }

            return View(enrolmentSeminar);
        }

        // GET: EnrolmentSeminar/Create
        public IActionResult Create()
        {
            ViewData["attendeeID"] = new SelectList(_context.Attendee, "attendeeID", "attendeeID");
            ViewData["seminarID"] = new SelectList(_context.Seminar, "seminarID", "seminarID");
            return View();
        }

        // POST: EnrolmentSeminar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("enrolmentSeminarID,seminarID,seminarTitle,attendeeID,attendeeName")] EnrolmentSeminar enrolmentSeminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrolmentSeminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["attendeeID"] = new SelectList(_context.Attendee, "attendeeID", "attendeeID", enrolmentSeminar.attendeeID);
            ViewData["seminarID"] = new SelectList(_context.Seminar, "seminarID", "seminarID", enrolmentSeminar.seminarID);
            return View(enrolmentSeminar);
        }

        // GET: EnrolmentSeminar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolmentSeminar = await _context.EnrolmentSeminar.FindAsync(id);
            if (enrolmentSeminar == null)
            {
                return NotFound();
            }
            ViewData["attendeeID"] = new SelectList(_context.Attendee, "attendeeID", "attendeeID", enrolmentSeminar.attendeeID);
            ViewData["seminarID"] = new SelectList(_context.Seminar, "seminarID", "seminarID", enrolmentSeminar.seminarID);
            return View(enrolmentSeminar);
        }

        // POST: EnrolmentSeminar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("enrolmentSeminarID,seminarID,seminarTitle,attendeeID,attendeeName")] EnrolmentSeminar enrolmentSeminar)
        {
            if (id != enrolmentSeminar.enrolmentSeminarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrolmentSeminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrolmentSeminarExists(enrolmentSeminar.enrolmentSeminarID))
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
            ViewData["attendeeID"] = new SelectList(_context.Attendee, "attendeeID", "attendeeID", enrolmentSeminar.attendeeID);
            ViewData["seminarID"] = new SelectList(_context.Seminar, "seminarID", "seminarID", enrolmentSeminar.seminarID);
            return View(enrolmentSeminar);
        }

        // GET: EnrolmentSeminar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolmentSeminar = await _context.EnrolmentSeminar
                .Include(e => e.attendees)
                .Include(e => e.seminar)
                .FirstOrDefaultAsync(m => m.enrolmentSeminarID == id);
            if (enrolmentSeminar == null)
            {
                return NotFound();
            }

            return View(enrolmentSeminar);
        }

        // POST: EnrolmentSeminar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrolmentSeminar = await _context.EnrolmentSeminar.FindAsync(id);
            _context.EnrolmentSeminar.Remove(enrolmentSeminar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrolmentSeminarExists(int id)
        {
            return _context.EnrolmentSeminar.Any(e => e.enrolmentSeminarID == id);
        }
    }
}
