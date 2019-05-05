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
    public class TableFormController : Controller
    {
        private readonly NewTestSixContext _context;

        public TableFormController(NewTestSixContext context)
        {
            _context = context;
        }


        // GET: FormData
        public async Task<IActionResult> Index()
        {
            return View(await _context.TableForm.ToListAsync());
        }

        // GET: FormData/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableForm = await _context.TableForm
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableForm == null)
            {
                return NotFound();
            }

            return View(tableForm);
        }

        // GET: SubmitFormV2/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string any = "")
        {
            IList<TableForm> _TableForm = new List<TableForm>();

            //Loop through the forms
            for (int i = 0; i <= Request.Form.Count; i++)
            {
                var ClientSampleID = Request.Form["ClientSampleID[" + i + "]"];
                var acidStables = Request.Form["AcidStables[" + i + "]"];
                //bool sulfurs = Request.Form["Sulfurs[i]"];


                if (!String.IsNullOrEmpty(ClientSampleID))
                {
                    _TableForm.Add(new TableForm { ClientSampleID = ClientSampleID, AcidStables = acidStables });
                }
            }

            //Once you got the records then you can do anything
            return View();
        }

        // POST: SubmitFormV2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientSampleID,AcidStables,Sulfurs,Trp,FAAs,AdditionalComments,_sampleMatrix")] TableForm tableForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tableForm);
        }
    }
}
