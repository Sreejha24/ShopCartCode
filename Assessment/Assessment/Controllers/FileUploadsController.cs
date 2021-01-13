using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assessment.Data;
using Assessment.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Assessment.Controllers
{
    public class FileUploadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FileUploadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FileUploads
        public async Task<IActionResult> Index()
        {
            return View(await _context.FileUpload.ToListAsync());
        }

        // GET: FileUploads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileUpload = await _context.FileUpload
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (fileUpload == null)
            {
                return NotFound();
            }

            return View(fileUpload);
        }

        // GET: FileUploads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FileUploads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpId,EmpName,photo")] FileUpload fileUpload, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                
                string path = Environment.CurrentDirectory;
                string fullName = Path.Combine(path, "wwwroot", "Images",photo.FileName);
                fileUpload.photo = fullName;
                    _context.Add(fileUpload);

                await _context.SaveChangesAsync();

                if(photo.Length>0)
                {
                    using(var stream = System.IO.File.Create(fullName))
                    {
                        await photo.CopyToAsync(stream);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fileUpload);


        }

        // GET: FileUploads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileUpload = await _context.FileUpload.FindAsync(id);
            if (fileUpload == null)
            {
                return NotFound();
            }
            return View(fileUpload);
        }

        // POST: FileUploads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpId,EmpName,photo")] FileUpload fileUpload)
        {
            if (id != fileUpload.EmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fileUpload);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FileUploadExists(fileUpload.EmpId))
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
            return View(fileUpload);
        }

        // GET: FileUploads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fileUpload = await _context.FileUpload
                .FirstOrDefaultAsync(m => m.EmpId == id);
            if (fileUpload == null)
            {
                return NotFound();
            }

            return View(fileUpload);
        }

        // POST: FileUploads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fileUpload = await _context.FileUpload.FindAsync(id);
            _context.FileUpload.Remove(fileUpload);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FileUploadExists(int id)
        {
            return _context.FileUpload.Any(e => e.EmpId == id);
        }
    }
}
