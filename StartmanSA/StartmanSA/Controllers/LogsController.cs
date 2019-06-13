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
    public class LogsController : Controller
    {
        private readonly StartmanSAContext _context;

        public LogsController(StartmanSAContext context)
        {
            _context = context;
        }

        // GET: Logs
        public async Task<IActionResult> Index(string LogEncarregado,string searchString)
        {
            IQueryable<string> EncarregadoQuery = from l in _context.Logs
                                            orderby l.Encarregado
                                            select l.Encarregado;
            var logs = from l in _context.Logs
                      select l;

            if (!string.IsNullOrEmpty(searchString))
            {
                logs = logs.Where(s => s.MateriaPrima.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(LogEncarregado))
            {
                logs = logs.Where(x => x.Encarregado == LogEncarregado);
                
            }

            var logsEncarregadosVM = new LogsEncarregadosViewModel
            {
                Encarregados = new SelectList(await EncarregadoQuery.Distinct().ToListAsync()),
                Logs = await logs.ToListAsync()
            };
            return View(logsEncarregadosVM);      
        }

        // GET: Logs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logs = await _context.Logs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logs == null)
            {
                return NotFound();
            }

            return View(logs);
        }

        // GET: Logs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logs = await _context.Logs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logs == null)
            {
                return NotFound();
            }

            return View(logs);
        }

        // POST: Logs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var logs = await _context.Logs.FindAsync(id);
            _context.Logs.Remove(logs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
