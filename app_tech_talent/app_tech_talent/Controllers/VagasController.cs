using app_tech_talent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var dados = await _context.Vagas.ToListAsync();

            return View(dados);
        }
    }
}
