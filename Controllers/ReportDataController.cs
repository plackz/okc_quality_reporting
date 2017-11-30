using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using okc_quality_reporting.Models;

namespace okc_quality_reporting.Controllers
{
    public class ReportDataController : Controller
    {
        private readonly okc_quality_reportingContext _context;

        public ReportDataController(okc_quality_reportingContext context)
        {
            _context = context;
        }

        // GET: ReportData
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
        }

        // GET: ReportData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportData = await _context.Movie
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reportData == null)
            {
                return NotFound();
            }

            return View(reportData);
        }

        // GET: ReportData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Month,MonthDate,CogsPercent")] ReportData reportData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportData);
        }

        // GET: ReportData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportData = await _context.Movie.SingleOrDefaultAsync(m => m.Id == id);
            if (reportData == null)
            {
                return NotFound();
            }
            return View(reportData);
        }

        // POST: ReportData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Month,MonthDate,CogsPercent")] ReportData reportData)
        {
            if (id != reportData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportDataExists(reportData.Id))
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
            return View(reportData);
        }

        // GET: ReportData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportData = await _context.Movie
                .SingleOrDefaultAsync(m => m.Id == id);
            if (reportData == null)
            {
                return NotFound();
            }

            return View(reportData);
        }

        // POST: ReportData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportData = await _context.Movie.SingleOrDefaultAsync(m => m.Id == id);
            _context.Movie.Remove(reportData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportDataExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
