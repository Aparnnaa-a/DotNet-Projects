using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CourseManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace CourseManagement.Controllers
{
    [Authorize]
    public class LessonPlansController : Controller
    {
        private readonly CourseManagementContext _context;

        public LessonPlansController(CourseManagementContext context)
        {
            _context = context;
        }

        // GET: LessonPlans
        public async Task<IActionResult> Index()
        {
            var courseManagementContext = _context.LessonPlans.Include(l => l.Course);
            return View(await courseManagementContext.ToListAsync());
        }

        // GET: LessonPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonPlan = await _context.LessonPlans
                .Include(l => l.Course)
                .FirstOrDefaultAsync(m => m.LessonPlanId == id);
            if (lessonPlan == null)
            {
                return NotFound();
            }

            return View(lessonPlan);
        }

        // GET: LessonPlans/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            return View();
        }

        // POST: LessonPlans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LessonPlanId,CourseId,Date,Topic,Assignment,Remarks")] LessonPlan lessonPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lessonPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", lessonPlan.CourseId);
            return View(lessonPlan);
        }

        // GET: LessonPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonPlan = await _context.LessonPlans.FindAsync(id);
            if (lessonPlan == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", lessonPlan.CourseId);
            return View(lessonPlan);
        }

        // POST: LessonPlans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LessonPlanId,CourseId,Date,Topic,Assignment,Remarks")] LessonPlan lessonPlan)
        {
            if (id != lessonPlan.LessonPlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lessonPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonPlanExists(lessonPlan.LessonPlanId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", lessonPlan.CourseId);
            return View(lessonPlan);
        }

        // GET: LessonPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonPlan = await _context.LessonPlans
                .Include(l => l.Course)
                .FirstOrDefaultAsync(m => m.LessonPlanId == id);
            if (lessonPlan == null)
            {
                return NotFound();
            }

            return View(lessonPlan);
        }

        // POST: LessonPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lessonPlan = await _context.LessonPlans.FindAsync(id);
            if (lessonPlan != null)
            {
                _context.LessonPlans.Remove(lessonPlan);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LessonPlanExists(int id)
        {
            return _context.LessonPlans.Any(e => e.LessonPlanId == id);
        }
    }
}
