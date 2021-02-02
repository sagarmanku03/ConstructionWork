using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConstructionWork.Data;
using ConstructionWork.Models;
using Microsoft.AspNetCore.Authorization;

namespace ConstructionWork.Controllers
{
    
    public class VaccenciesController : Controller
    {
        private readonly ConstructionWorkContext _context;

        public VaccenciesController(ConstructionWorkContext context)
        {
            _context = context;
        }

        // GET: Vaccencies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vaccencie.ToListAsync());
        }

        // GET: Vaccencies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccencie = await _context.Vaccencie
                .FirstOrDefaultAsync(m => m.JobID == id);
            if (vaccencie == null)
            {
                return NotFound();
            }

            return View(vaccencie);
        }
         [Authorize]
        // GET: Vaccencies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaccencies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobID,JobType,StartDate,EndDate")] Vaccencie vaccencie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccencie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccencie);
        }
         [Authorize]
        // GET: Vaccencies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccencie = await _context.Vaccencie.FindAsync(id);
            if (vaccencie == null)
            {
                return NotFound();
            }
            return View(vaccencie);
        }

        // POST: Vaccencies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobID,JobType,StartDate,EndDate")] Vaccencie vaccencie)
        {
            if (id != vaccencie.JobID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccencie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccencieExists(vaccencie.JobID))
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
            return View(vaccencie);
        }

        // GET: Vaccencies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccencie = await _context.Vaccencie
                .FirstOrDefaultAsync(m => m.JobID == id);
            if (vaccencie == null)
            {
                return NotFound();
            }

            return View(vaccencie);
        }

        // POST: Vaccencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccencie = await _context.Vaccencie.FindAsync(id);
            _context.Vaccencie.Remove(vaccencie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccencieExists(int id)
        {
            return _context.Vaccencie.Any(e => e.JobID == id);
        }
    }
}
