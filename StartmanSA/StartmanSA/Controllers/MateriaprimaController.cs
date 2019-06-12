using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StartmanSA.Models;

namespace StartmanSA.Controllers
{
    public class MateriaprimaController : Controller
    {
        private readonly StartmanSAContext _context;

        public MateriaprimaController(StartmanSAContext context)
        {
            _context = context;
        }

        // GET: Materiaprima
        public async Task<IActionResult> Index(string searchString)
        {
            var materiaprima = from m in _context.Materiaprima select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                materiaprima = materiaprima.Where(s => s.Nome.Contains(searchString));
            }

            return View(await materiaprima.ToListAsync());
        }
        //[HttpPost]
        //public string Index(string searchString, bool notUsed)
        //{
        //    return "From [HttpPost]Index: filter on " + searchString;
        //}

        // GET: Materiaprima/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaprima = await _context.Materiaprima
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaprima == null)
            {
                return NotFound();
            }

            return View(materiaprima);
        }

        // GET: Materiaprima/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materiaprima/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,QuantidadeEstoque,QuantidadeEstoqueMax")] Materiaprima materiaprima)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materiaprima);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materiaprima);
        }

        // GET: Materiaprima/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaprima = await _context.Materiaprima.FindAsync(id);
            if (materiaprima == null)
            {
                return NotFound();
            }
            return View(materiaprima);
        }

        // POST: Materiaprima/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,QuantidadeEstoque,QuantidadeEstoqueMax")] Materiaprima materiaprima)
        {
            if (id != materiaprima.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiaprima);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaprimaExists(materiaprima.Id))
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
            return View(materiaprima);
        }

        // GET: Materiaprima/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaprima = await _context.Materiaprima
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaprima == null)
            {
                return NotFound();
            }

            return View(materiaprima);
        }

        // POST: Materiaprima/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materiaprima = await _context.Materiaprima.FindAsync(id);
            _context.Materiaprima.Remove(materiaprima);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriaprimaExists(int id)
        {
            return _context.Materiaprima.Any(e => e.Id == id);
        }
    }
}
