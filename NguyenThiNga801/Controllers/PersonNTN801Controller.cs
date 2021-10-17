using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiNga801.Data;
using NguyenThiNga801.Models;

namespace NguyenThiNga801.Controllers
{
    public class PersonNTN801Controller : Controller
    {
        private readonly NguyenThiNga801Context _context;

        public PersonNTN801Controller(NguyenThiNga801Context context)
        {
            _context = context;
        }

        // GET: PersonNTN801
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNTN801.ToListAsync());
        }

        // GET: PersonNTN801/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN801 = await _context.PersonNTN801
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTN801 == null)
            {
                return NotFound();
            }

            return View(personNTN801);
        }

        // GET: PersonNTN801/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNTN801/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonNTN801 personNTN801)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNTN801);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNTN801);
        }

        // GET: PersonNTN801/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN801 = await _context.PersonNTN801.FindAsync(id);
            if (personNTN801 == null)
            {
                return NotFound();
            }
            return View(personNTN801);
        }

        // POST: PersonNTN801/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonNTN801 personNTN801)
        {
            if (id != personNTN801.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNTN801);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNTN801Exists(personNTN801.PersonId))
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
            return View(personNTN801);
        }

        // GET: PersonNTN801/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNTN801 = await _context.PersonNTN801
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personNTN801 == null)
            {
                return NotFound();
            }

            return View(personNTN801);
        }

        // POST: PersonNTN801/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNTN801 = await _context.PersonNTN801.FindAsync(id);
            _context.PersonNTN801.Remove(personNTN801);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNTN801Exists(string id)
        {
            return _context.PersonNTN801.Any(e => e.PersonId == id);
        }
    }
}
