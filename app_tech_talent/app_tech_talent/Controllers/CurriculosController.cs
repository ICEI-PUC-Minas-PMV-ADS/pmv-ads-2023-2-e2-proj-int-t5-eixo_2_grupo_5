using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class CurriculosController : Controller
    {
        private readonly AppDbContext _context;

        public CurriculosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Curriculos
        public async Task<IActionResult> Index()
        {

            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var profissional = _context.Profissionais.FirstOrDefault(p => p.UsuarioId == userId);

            var curriculo = await _context.Curriculo.FirstOrDefaultAsync(u => u.CPF == profissional.CPF);

            if (curriculo != null)
            {
                var curriculoList = new List<Curriculo> { curriculo };
                return View(curriculoList);

            }

            return RedirectToAction(nameof(Create));

        }

        // GET: Curriculos/Details/5

public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo
                .FirstOrDefaultAsync(m => m.IdCurriculo == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // Insert: Curriculos/Create
        public IActionResult Create()

        {
            return View();
        }

        // POST: Curriculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCurriculo,CPF,ResumoProfissional")] Curriculo curriculo)
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var profissional = _context.Profissionais.FirstOrDefault(p => p.UsuarioId == userId);
           
            curriculo.CPF = profissional.CPF;

            if (ModelState.IsValid)
            {
                
                _context.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(curriculo);

        }

        // GET: Curriculos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo.FindAsync(id);
            if (curriculo == null)
            {
                return NotFound();
            }
            return View(curriculo);
        }

        // POST: Curriculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCurriculo,CPF,ResumoProfissional")] Curriculo curriculo)
        {
            if (id != curriculo.IdCurriculo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curriculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurriculoExists(curriculo.IdCurriculo))
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
            return View(curriculo);
        }

        // GET: Curriculos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Curriculo == null)
            {
                return NotFound();
            }

            var curriculo = await _context.Curriculo
                .FirstOrDefaultAsync(m => m.IdCurriculo == id);
            if (curriculo == null)
            {
                return NotFound();
            }

            return View(curriculo);
        }

        // POST: Curriculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Curriculo == null)
            {
                return Problem("Entity set 'AppDbContext.Curriculo'  is null.");
            }
            var curriculo = await _context.Curriculo.FindAsync(id);
            if (curriculo != null)
            {
                _context.Curriculo.Remove(curriculo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurriculoExists(int id)
        {
          return _context.Curriculo.Any(e => e.IdCurriculo == id);
        }

        }
}
