using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportProject.Data;
using SportProject.Models;

namespace SportProject.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CoursesController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Courses
        public async Task<IActionResult> Index(string CourseBranch, string searchString)
        {
            IQueryable<string> BranchQuery = from m in _context.Courses
                                             orderby m.Sports.SportName
                                             select m.Sports.SportName;
            var kurs = from m in _context.Courses
                       select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                kurs = kurs.Where(s => s.CourseName.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(CourseBranch))
            {
                kurs = kurs.Where(x => x.Sports.SportName == CourseBranch);
            }
            var CourseSportsVM = new CoursesSportsViewModel
            {
                Sport = new SelectList(await BranchQuery.Distinct().ToListAsync()),
                Courses = await kurs.ToListAsync()
            };
            return View(CourseSportsVM);
        }
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "Filter" + searchString;
        }

        [Authorize]
        public IActionResult kampanyalar()
        {
            return View();
        }

        // GET: Courses/Details/5

        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.Sports)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // GET: Courses/Create

        public IActionResult Create()
        {
            ViewData["SportsId"] = new SelectList(_context.Sports, "SportId", "SportName");
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("CourseId,CourseName,SiteUrl,InfoCourse,ActTime,SportsId")] Courses courses)
        {
            if (ModelState.IsValid)
            {
                //**
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\kurs");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                courses.SiteUrl = @"\images\kurs\" + fileName + extension;

                //****
                _context.Add(courses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SportsId"] = new SelectList(_context.Sports, "SportId", "SportName", courses.SportsId);
            return View(courses);
        }

        // GET: Courses/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.FindAsync(id);
            if (courses == null)
            {
                return NotFound();
            }
            ViewData["SportsId"] = new SelectList(_context.Sports, "SportId", "SportId", courses.SportsId);
            return View(courses);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("CourseId,CourseName,SiteUrl,InfoCourse,ActTime,SportsId")] Courses courses)
        {
            if (id != courses.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursesExists(courses.CourseId))
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
            ViewData["SportsId"] = new SelectList(_context.Sports, "SportId", "SportId", courses.SportsId);
            return View(courses);
        }

        // GET: Courses/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses
                .Include(c => c.Sports)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courses == null)
            {
                return NotFound();
            }

            return View(courses);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courses = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursesExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }
    }
}
