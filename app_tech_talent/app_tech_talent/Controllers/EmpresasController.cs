using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class EmpresasController : Controller
    {
        private readonly AppDbContext _context;

        public EmpresasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Empresas
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                var empresa = await _context.Empresas
                    .Include(p => p.Usuario)
                    .FirstOrDefaultAsync(p => p.UsuarioId == usuarioId);

                if (empresa != null)
                {

                    var empresaList = new List<Empresa> { empresa };

                    return View(empresaList);
                }
            }

            return View(new List<Empresa>());
        }

        // GET: Empresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas
                .Include(e => e.Usuario)
                .FirstOrDefaultAsync(m => m.EmpresaId == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

        // GET: Empresas/Create
        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                var existingEmpresa = _context.Empresas.FirstOrDefault(p => p.UsuarioId == usuarioId);

                if (existingEmpresa != null)
                {
                    return RedirectToAction("Details", new { id = existingEmpresa.EmpresaId });
                }

                ViewBag.UsuarioId = usuarioId;
                return View();
            }
            else
            {

                return NotFound();
            }
        }

        // POST: Empresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpresaId,RazaoSocial,CNPJ,Logradouro,UF,CEP,Bairro,Cidade,WebSite,Descricao,UsuarioId")] Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                empresa.UsuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

                _context.Add(empresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", empresa.UsuarioId);
            return View(empresa);
        }

        // GET: Empresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }


            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (empresa.UsuarioId != usuarioId)
            {

                return Forbid();
            }

            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", empresa.UsuarioId);
            return View(empresa);
        }

        // POST: Empresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpresaId,RazaoSocial,CNPJ,Logradouro,UF,CEP,Bairro,Cidade,WebSite,Descricao,UsuarioId")] Empresa empresa)
        {
            if (id != empresa.EmpresaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empresa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(empresa.EmpresaId))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "UsuarioId", "Email", empresa.UsuarioId);
            return View(empresa);
        }

        // GET: Empresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas
                .Include(e => e.Usuario)
                .FirstOrDefaultAsync(m => m.EmpresaId == id);
            if (empresa == null)
            {
                return NotFound();
            }

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));


            if (empresa.UsuarioId != usuarioId)
            {

                return Forbid();
            }

            return View(empresa);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Empresas == null)
            {
                return Problem("Entity set 'AppDbContext.Empresas'  is null.");
            }
            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaExists(int id)
        {
          return _context.Empresas.Any(e => e.EmpresaId == id);
        }
    }
}
