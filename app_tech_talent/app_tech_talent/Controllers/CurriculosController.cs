using app_tech_talent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app_tech_talent.Controllers
{
    public class CurriculosController : Controller
    {
        private readonly AppDbContext _context;
        public CurriculosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Curriculo curriculo)
        {
            if (ModelState.IsValid)
            { 

                _context.Curriculos.Add(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(curriculo);
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Curriculos.ToListAsync();

            return View(dados);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Curriculo curriculo)
        {
            if (id != curriculo.IdCurriculo)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Curriculos.Update(curriculo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if(id==null)
                return NotFound();

            var dados = await _context.Curriculos.FindAsync(id);

            if(dados==null)
                return NotFound();

            return View(dados);
        }
        }
    }
