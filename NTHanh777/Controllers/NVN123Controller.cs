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
    public class NVN123Controller : Controller
    {
        private readonly NTHanh777Context _context;

        public NVN123Controller(NTHanh777Context context)
        {
            _context = context;
        }

        // GET: NVN123
        public async Task<IActionResult> Index()
        {
            return View(await _context.NVN123.ToListAsync());
        }

        // GET: NVN123/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVN123 = await _context.NVN123
                .FirstOrDefaultAsync(m => m.NVNId == id);
            if (nVN123 == null)
            {
                return NotFound();
            }

            return View(nVN123);
        }

        // GET: NVN123/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NVN123/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NVNId,NVNName,Gender")] NVN123 nVN123)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nVN123);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nVN123);
        }

        // GET: NVN123/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVN123 = await _context.NVN123.FindAsync(id);
            if (nVN123 == null)
            {
                return NotFound();
            }
            return View(nVN123);
        }

        // POST: NVN123/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NVNId,NVNName,Gender")] NVN123 nVN123)
        {
            if (id != nVN123.NVNId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nVN123);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NVN123Exists(nVN123.NVNId))
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
            return View(nVN123);
        }

        // GET: NVN123/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nVN123 = await _context.NVN123
                .FirstOrDefaultAsync(m => m.NVNId == id);
            if (nVN123 == null)
            {
                return NotFound();
            }

            return View(nVN123);
        }

        // POST: NVN123/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nVN123 = await _context.NVN123.FindAsync(id);
            _context.NVN123.Remove(nVN123);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NVN123Exists(string id)
        {
            return _context.NVN123.Any(e => e.NVNId == id);
        }
    }
}
