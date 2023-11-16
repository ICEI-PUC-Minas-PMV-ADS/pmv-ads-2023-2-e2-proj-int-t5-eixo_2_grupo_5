using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class VagasController : Controller
    {
        private readonly AppDbContext _context;

        public VagasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
                var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);
                var empresa = await _context.Empresas.FirstOrDefaultAsync(e => e.UsuarioId == userId);

                if (empresa != null)
                {
                    var vagas = await _context.Vagas.Where(v => v.EmpresaId == empresa.EmpresaId).ToListAsync();
                    return View(vagas);
                }
            }

            return View(new List<Vaga>());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Vaga vaga)
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);
            var empresa = await _context.Empresas.FirstOrDefaultAsync(e => e.UsuarioId == userId);

            vaga.EmpresaId = empresa.EmpresaId;

            if (ModelState.IsValid)
            {
                _context.Vagas.Add(vaga);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vaga);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Vagas.FindAsync(Id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Vaga vaga)
        {
            if (Id != vaga.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Vagas.Update(vaga);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Vagas.FindAsync(Id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Vagas.FindAsync(Id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? Id)
        {
            if (Id == null)
                return NotFound();

            var dados = await _context.Vagas.FindAsync(Id);

            if (dados == null)
                return NotFound();

            _context.Vagas.Remove(dados);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> VagasDisponiveis()
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var profissional = await _context.Profissionais.FirstOrDefaultAsync(e => e.UsuarioId == userId);

            if (profissional != null)
            {
                // Obter as IDs das vagas às quais o profissional já se candidatou
                var idsVagasCandidatadas = await _context.Candidaturas
                    .Where(c => c.ProfissionalId == profissional.ProfissionalId)
                    .Select(c => c.VagaId)
                    .ToListAsync();

                // Filtrar vagas disponíveis que o profissional ainda não se candidatou
                var vagasDisponiveis = await _context.Vagas
                    .Where(v => !idsVagasCandidatadas.Contains(v.Id))
                    .ToListAsync();

                return View(vagasDisponiveis);
            }

            // O profissional não foi encontrado, você pode tratar isso de acordo com sua lógica
            return View(new List<Vaga>()); // Ou redirecionar para uma página de erro, por exemplo.
        }

        [Authorize(Roles = "Profissional")]
        public async Task<IActionResult> VagasCandidatadas()
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var profissional = await _context.Profissionais.FirstOrDefaultAsync(e => e.UsuarioId == userId);

            if (profissional != null)
            {
                // Obter as IDs das vagas às quais o profissional já se candidatou
                var idsVagasCandidatadas = await _context.Candidaturas
                    .Where(c => c.ProfissionalId == profissional.ProfissionalId)
                    .Select(c => c.VagaId)
                    .ToListAsync();

                // Filtrar vagas disponíveis que o profissional ainda não se candidatou
                var vagasDisponiveis = await _context.Vagas
                    .Where(v => idsVagasCandidatadas.Contains(v.Id))
                    .ToListAsync();

                return View(vagasDisponiveis);
            }

            // O profissional não foi encontrado, você pode tratar isso de acordo com sua lógica
            return View(new List<Vaga>()); // Ou redirecionar para uma página de erro, por exemplo.
        }

        [HttpPost]
        public async Task<IActionResult> Candidatar(int vagaId)
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.UsuarioId == userId);
            var profissional = await _context.Profissionais.FirstOrDefaultAsync(e => e.UsuarioId == userId);
            var candidatura = new Candidatura();

            candidatura.ProfissionalId = profissional.ProfissionalId; 
            candidatura.VagaId = vagaId;
            candidatura.Status = Status.Enviada;

            if (ModelState.IsValid)
            {
                _context.Candidaturas.Add(candidatura);
                await _context.SaveChangesAsync();
                return RedirectToAction("VagasDisponiveis");
            }

            return View();

        }

        [Authorize(Roles = "Empresa")]
        public async Task<IActionResult> Candidaturas()
        {
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var empresa = await _context.Empresas.FirstOrDefaultAsync(e => e.UsuarioId == userId);

            if (empresa != null)
            {
                // Obter as IDs das vagas associadas à empresa
                var idsVagasDaEmpresa = await _context.Vagas
                    .Where(v => v.EmpresaId == empresa.EmpresaId)
                    .Select(v => v.Id)
                    .ToListAsync();

                // Obter as candidaturas relacionadas às vagas da empresa
                var candidaturasDaEmpresa = await _context.Candidaturas
                    .Where(c => idsVagasDaEmpresa.Contains(c.VagaId))
                    .ToListAsync();

                // Obter os IDs dos profissionais associados às candidaturas
                var idsProfissionais = candidaturasDaEmpresa.Select(c => c.ProfissionalId).ToList();

                // Obter informações sobre os profissionais
                var profissionais = await _context.Profissionais
                    .Where(p => idsProfissionais.Contains(p.ProfissionalId))
                    .ToListAsync();

                ViewBag.Candidaturas = candidaturasDaEmpresa;
                ViewBag.Profissionais = profissionais;

                return View();
            }

            // A empresa não foi encontrada, você pode tratar isso de acordo com sua lógica
            return View(new { Candidaturas = new List<Candidatura>(), Profissionais = new List<Profissional>() });
        }
    }
}
