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
    public class ExperienciaProfissionalController : Controller
    {
        private readonly AppDbContext _context;

        public ExperienciaProfissionalController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ExperienciaProfissional
        public async Task<IActionResult> Index()
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);

            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == userId);

            var curriculo = _context.Curriculo.FirstOrDefault(c => c.CPF == profissional.CPF);

            var experienciaProfissional = await _context.ExperienciaProfissional.Where(u => u.IdCurriculo == curriculo.IdCurriculo).ToListAsync();

            if (experienciaProfissional != null)
            {

                return View(experienciaProfissional);
            }


            return RedirectToAction(nameof(Create));
        }


        // GET: ExperienciaProfissional/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ExperienciaProfissional == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional
                .FirstOrDefaultAsync(m => m.IdExperienciaProfissional == id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }

            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExperienciaProfissional/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdExperienciaProfissional,IdCurriculo,Empresa,Cargo,DataDeInicio,DataDeTermino,ResumoDaAtuacao")] ExperienciaProfissional experienciaProfissional)
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);

            var profissional = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == userId);

            var curriculo = _context.Curriculo.FirstOrDefault(c => c.CPF == profissional.CPF);

            experienciaProfissional.IdCurriculo = curriculo.IdCurriculo;

            if (ModelState.IsValid)
            {
                _context.Add(experienciaProfissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ExperienciaProfissional == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional.FindAsync(id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }
            return View(experienciaProfissional);
        }

        // POST: ExperienciaProfissional/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdExperienciaProfissional,IdCurriculo,Empresa,Cargo,DataDeInicio,DataDeTermino,ResumoDaAtuacao")] ExperienciaProfissional experienciaProfissional)
        {
            if (id != experienciaProfissional.IdExperienciaProfissional)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(experienciaProfissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienciaProfissionalExists(experienciaProfissional.IdExperienciaProfissional))
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
            return View(experienciaProfissional);
        }

        // GET: ExperienciaProfissional/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ExperienciaProfissional == null)
            {
                return NotFound();
            }

            var experienciaProfissional = await _context.ExperienciaProfissional
                .FirstOrDefaultAsync(m => m.IdExperienciaProfissional == id);
            if (experienciaProfissional == null)
            {
                return NotFound();
            }

            return View(experienciaProfissional);
        }

        // POST: ExperienciaProfissional/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ExperienciaProfissional == null)
            {
                return Problem("Entity set 'AppDbContext.ExperienciaProfissional'  is null.");
            }
            var experienciaProfissional = await _context.ExperienciaProfissional.FindAsync(id);
            if (experienciaProfissional != null)
            {
                _context.ExperienciaProfissional.Remove(experienciaProfissional);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExperienciaProfissionalExists(int id)
        {
          return _context.ExperienciaProfissional.Any(e => e.IdExperienciaProfissional == id);
        }
    }
}
