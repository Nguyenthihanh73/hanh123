using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NTHanh777.Data;
using NTHanh777.Models;

namespace NTHanh777.Controllers
{
    public class PersonNT77Controller : Controller
    {
        private readonly NTHanh777Context _context;

        public PersonNT77Controller(NTHanh777Context context)
        {
            _context = context;
        }

        // GET: PersonNT77
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonNT77.ToListAsync());
        }

        // GET: PersonNT77/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNT77 = await _context.PersonNT77
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNT77 == null)
            {
                return NotFound();
            }

            return View(personNT77);
        }

        // GET: PersonNT77/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonNT77/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonNT77 personNT77)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personNT77);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personNT77);
        }

        // GET: PersonNT77/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNT77 = await _context.PersonNT77.FindAsync(id);
            if (personNT77 == null)
            {
                return NotFound();
            }
            return View(personNT77);
        }

        // POST: PersonNT77/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonNT77 personNT77)
        {
            if (id != personNT77.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personNT77);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonNT77Exists(personNT77.PersonID))
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
            return View(personNT77);
        }

        // GET: PersonNT77/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personNT77 = await _context.PersonNT77
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personNT77 == null)
            {
                return NotFound();
            }

            return View(personNT77);
        }

        // POST: PersonNT77/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personNT77 = await _context.PersonNT77.FindAsync(id);
            _context.PersonNT77.Remove(personNT77);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonNT77Exists(string id)
        {
            return _context.PersonNT77.Any(e => e.PersonID == id);
        }
    }
}
