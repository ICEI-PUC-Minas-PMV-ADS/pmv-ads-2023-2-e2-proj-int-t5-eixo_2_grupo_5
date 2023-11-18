using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class ProfissionaisController : Controller
    {
        private readonly AppDbContext _context;

        public ProfissionaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Profissionais
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                var profissional = await _context.Profissionais
                    .Include(p => p.Usuario)
                    .FirstOrDefaultAsync(p => p.UsuarioId == usuarioId);

                if (profissional != null)
                {

                    var profissionaisList = new List<Profissional> { profissional };

                    return View(profissionaisList);
                }
            }

            return View(new List<Profissional>());
        }

        // GET: Profissionais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profissionais == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissionais
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ProfissionalId == id);
            if (profissional == null)
            {
                return NotFound();
            }

            return View(profissional);
        }

        // GET: Profissionais/Create
        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                var existingProfissional = _context.Profissionais.FirstOrDefault(p => p.UsuarioId == usuarioId);

                if (existingProfissional != null)
                {
                    return RedirectToAction("Details", new { id = existingProfissional.ProfissionalId });
                }

                ViewBag.UsuarioId = usuarioId;
                return View();
            }
            else
            {
                return NotFound();
            }
        }

        // POST: Profissionais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("ProfissionalId,Nome,UsuarioId,CPF,Idade")] Profissional profissional)
        {
            if (ModelState.IsValid)
            {

                profissional.UsuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                _context.Add(profissional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", profissional.UsuarioId);
            return View(profissional);
        }

        // GET: Profissionais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profissionais == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissionais.FindAsync(id);

            if (profissional == null)
            {
                return NotFound();
            }

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (profissional.UsuarioId != usuarioId)
            {

                return Forbid();
            }

            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", profissional.UsuarioId);
            return View(profissional);
        }


        // POST: Profissionais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfissionalId,Nome,UsuarioId,CPF,Idade")] Profissional profissional)
        {

            if (id != profissional.ProfissionalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    profissional.UsuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                    _context.Update(profissional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfissionalExists(profissional.ProfissionalId))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", profissional.UsuarioId);
            return View(profissional);
        }

        // GET: Profissionais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profissionais == null)
            {
                return NotFound();
            }

            var profissional = await _context.Profissionais
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.ProfissionalId == id);

            if (profissional == null)
            {
                return NotFound();
            }

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));


            if (profissional.UsuarioId != usuarioId)
            {

                return Forbid();
            }

            return View(profissional);
        }


        // POST: Profissionais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Profissionais == null)
            {
                return Problem("Entity set 'AppDbContext.Profissionais'  is null.");
            }
            var profissional = await _context.Profissionais.FindAsync(id);

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var usuario = await _context.Usuarios.FindAsync(usuarioId);

            if (profissional != null)
            {
                _context.Profissionais.Remove(profissional);
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Logout", "Usuarios");
        }

        private bool ProfissionalExists(int id)
        {
          return _context.Profissionais.Any(e => e.ProfissionalId == id);
        }
    }
}
