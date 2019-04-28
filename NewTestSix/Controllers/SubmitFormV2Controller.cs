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
    public class SubmitFormV2Controller : Controller
    {
        private readonly NewTestSixContext _context;

        public SubmitFormV2Controller(NewTestSixContext context)
        {
            _context = context;
        }


        // GET: FormData
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubmitFormV2.ToListAsync());
        }

        // GET: FormData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submitFormV2 = await _context.SubmitFormV2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submitFormV2 == null)
            {
                return NotFound();
            }

            return View(submitFormV2);
        }

        // GET: SubmitFormV2/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: SubmitFormV2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientSampleID,AcidStables,Sulfurs,Trp,FAAs,AdditionalComments,_sampleMatrix")] SubmitFormV2 submitFormV2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(submitFormV2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submitFormV2);
        }
    }
}
