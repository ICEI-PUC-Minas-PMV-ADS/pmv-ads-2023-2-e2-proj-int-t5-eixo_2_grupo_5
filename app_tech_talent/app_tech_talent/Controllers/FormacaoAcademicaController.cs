using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);

            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == userId);

            var curriculo = _context.Curriculo.FirstOrDefault(c => c.CPF == profissional.CPF);

            var formacaoAcademica = await _context.FormacaoAcademica.Where(u => u.IdCurriculo == curriculo.IdCurriculo).ToListAsync();

                if (formacaoAcademica != null)
                {
                  
                    return View(formacaoAcademica);
                }
            

            return RedirectToAction(nameof(Create));
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
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);

            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == userId);

            var curriculo = _context.Curriculo.FirstOrDefault(c => c.CPF == profissional.CPF);
            
            formacaoAcademica.IdCurriculo = curriculo.IdCurriculo;

                if (ModelState.IsValid) 
                {
                    formacaoAcademica.AnoDeConclusao = DateTime.SpecifyKind(formacaoAcademica.AnoDeConclusao, DateTimeKind.Utc);
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
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);

            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == userId);

            var curriculo = _context.Curriculo.FirstOrDefault(c => c.CPF == profissional.CPF);

            formacaoAcademica.IdCurriculo = curriculo.IdCurriculo;

            if (id != formacaoAcademica.IdFormacaoAcademica)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    formacaoAcademica.AnoDeConclusao = DateTime.SpecifyKind(formacaoAcademica.AnoDeConclusao, DateTimeKind.Utc);
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
