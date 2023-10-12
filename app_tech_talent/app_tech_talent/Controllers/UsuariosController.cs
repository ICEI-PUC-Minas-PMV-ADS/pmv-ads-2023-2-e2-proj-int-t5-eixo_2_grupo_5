using app_tech_talent.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_tech_talent.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: Usuarios/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioId, Email, Senha, TipoUsuario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                if (usuario.TipoUsuario == TipoUsuario.Profissional)
                {
                    _context.Usuarios.Add(usuario);
                    await _context.SaveChangesAsync();

                    Profissional profissional = new Profissional
                    {
                        UsuarioId = usuario.UsuarioId,
                        Nome = "",
                    };

                    _context.Profissionais.Add(profissional);
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(usuario);
        }
    }
}
