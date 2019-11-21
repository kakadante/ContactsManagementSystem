using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactsManagementSystem.Models;

namespace ContactsManagementSystem.Controllers
{
    public class AllcontactsController : Controller
    {
        private readonly AllcontactsContext _context;

        public AllcontactsController(AllcontactsContext context)
        {
            _context = context;
        }

        // GET: Allcontacts
        public async Task<IActionResult> Index()
        {
            var allcontactsContext = _context.Allcontacts.Include(a => a.Gender);
            return View(await allcontactsContext.ToListAsync());
        }



        // GET: Allcontacts/Create
        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Id");

            if(id==0)
            return View(new Allcontacts());
            else
            return View(_context.Allcontacts.Find(id));

        }

        // POST: Allcontacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("AllcontactsId,Name,Phone_Number,Email,GenderId")] Allcontacts allcontacts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allcontacts);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenderId"] = new SelectList(_context.Gender, "Id", "Id", allcontacts.GenderId);
            return View(allcontacts);
        }


        // GET: Allcontacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allcontacts = await _context.Allcontacts
                .Include(a => a.Gender)
                .FirstOrDefaultAsync(m => m.AllcontactsId == id);
            if (allcontacts == null)
            {
                return NotFound();
            }

            return View(allcontacts);
        }

       
    }
}
