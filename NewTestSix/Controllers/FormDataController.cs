using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewTestSix.Models;

namespace NewTestSix.Controllers
{
    public class FormDataController : Controller
    {
        private readonly NewTestSixContext _context;

        public FormDataController(NewTestSixContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void FormOne(string textBoxStringData, int textBoxIntData, string checkboxData)
        {
            //Do something
        }

        [HttpPost]
        public void FormTwo(Models.FormData formData)
        {
            //Do something with formData
        }

        // GET: FormData
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormData.ToListAsync());
        }

        // GET: FormData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formData = await _context.FormData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formData == null)
            {
                return NotFound();
            }

            return View(formData);
        }

        // GET: FormData/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TextBoxStringData,TextBoxIntData,CheckboxData")] FormData formData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formData);
        }

        // GET: FormData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formData = await _context.FormData.FindAsync(id);
            if (formData == null)
            {
                return NotFound();
            }
            return View(formData);
        }

        // POST: FormData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TextBoxStringData,TextBoxIntData,CheckboxData")] FormData formData)
        {
            if (id != formData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormDataExists(formData.Id))
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
            return View(formData);
        }

        // GET: FormData/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formData = await _context.FormData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formData == null)
            {
                return NotFound();
            }

            return View(formData);
        }

        // POST: FormData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formData = await _context.FormData.FindAsync(id);
            _context.FormData.Remove(formData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormDataExists(int id)
        {
            return _context.FormData.Any(e => e.Id == id);
        }
    }
}
