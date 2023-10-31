using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class FormacaoAcademicaController : Controller
    {
        private readonly AppDbContext _context;

        public FormacaoAcademicaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: FormacaoAcademica
        public async Task<IActionResult> Index()
        {
              return View(await _context.FormacaoAcademica.ToListAsync());
        }

        // GET: FormacaoAcademica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FormacaoAcademica == null)
            {
                return NotFound();
            }

            var formacaoAcademica = await _context.FormacaoAcademica
                .FirstOrDefaultAsync(m => m.IdFormacaoAcademica == id);
            if (formacaoAcademica == null)
            {
                return NotFound();
            }

            return View(formacaoAcademica);
        }

        // GET: FormacaoAcademica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormacaoAcademica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdFormacaoAcademica,IdCurriculo,InstituicaoDeEnsino,grauObtido,AnoDeConclusao,AreaDeEstudo")] FormacaoAcademica formacaoAcademica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formacaoAcademica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formacaoAcademica);
        }

        // GET: FormacaoAcademica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FormacaoAcademica == null)
            {
                return NotFound();
            }

            var formacaoAcademica = await _context.FormacaoAcademica.FindAsync(id);
            if (formacaoAcademica == null)
            {
                return NotFound();
            }
            return View(formacaoAcademica);
        }

        // POST: FormacaoAcademica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdFormacaoAcademica,IdCurriculo,InstituicaoDeEnsino,grauObtido,AnoDeConclusao,AreaDeEstudo")] FormacaoAcademica formacaoAcademica)
        {
            if (id != formacaoAcademica.IdFormacaoAcademica)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formacaoAcademica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormacaoAcademicaExists(formacaoAcademica.IdFormacaoAcademica))
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
            return View(formacaoAcademica);
        }

        // GET: FormacaoAcademica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FormacaoAcademica == null)
            {
                return NotFound();
            }

            var formacaoAcademica = await _context.FormacaoAcademica
                .FirstOrDefaultAsync(m => m.IdFormacaoAcademica == id);
            if (formacaoAcademica == null)
            {
                return NotFound();
            }

            return View(formacaoAcademica);
        }

        // POST: FormacaoAcademica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FormacaoAcademica == null)
            {
                return Problem("Entity set 'AppDbContext.FormacaoAcademica'  is null.");
            }
            var formacaoAcademica = await _context.FormacaoAcademica.FindAsync(id);
            if (formacaoAcademica != null)
            {
                _context.FormacaoAcademica.Remove(formacaoAcademica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormacaoAcademicaExists(int id)
        {
          return _context.FormacaoAcademica.Any(e => e.IdFormacaoAcademica == id);
        }
    }
}
