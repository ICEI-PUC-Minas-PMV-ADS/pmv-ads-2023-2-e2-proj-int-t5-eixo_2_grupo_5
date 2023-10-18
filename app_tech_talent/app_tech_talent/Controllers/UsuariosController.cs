﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using app_tech_talent.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace app_tech_talent.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            // Obtenha o ID do usuário autenticado
            var userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Verifique se o usuário autenticado criou um perfil de usuário
            var isUserWithProfile = await _context.Usuarios.AnyAsync(u => u.UsuarioId == userId);

            if (isUserWithProfile)
            {
                // Se o usuário autenticado criou um perfil de usuário, exiba os detalhes
                var usuario = await _context.Usuarios
                    .FirstOrDefaultAsync(u => u.UsuarioId == userId);

                return View(new List<Usuario> { usuario });
            }

            // Se o usuário autenticado não criou um perfil de usuário, exiba uma lista vazia
            return View(new List<Usuario>());
        }


        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {

            var dados = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (dados != null && BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, dados.Email),
                    new Claim(ClaimTypes.Name, dados.Email),
                    new Claim(ClaimTypes.NameIdentifier, dados.UsuarioId.ToString()),
                    new Claim(ClaimTypes.Role, dados.TipoUsuario.ToString()),
                };

                var usuarioIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                if (dados.TipoUsuario == TipoUsuario.Profissional)
                {
                    var profissionalExistente = await _context.Profissionais.FirstOrDefaultAsync(p => p.UsuarioId == dados.UsuarioId);

                    if (profissionalExistente != null)
                    {
                        return Redirect("/");
                    }
                    else
                    {
                        return RedirectToAction("Create", "Profissionais");
                    }
                }
                else if (dados.TipoUsuario == TipoUsuario.Empresa)
                {
                    var empresaExistente = await _context.Empresas.FirstOrDefaultAsync(e => e.UsuarioId == dados.UsuarioId);

                    if (empresaExistente != null)
                    {
                        return Redirect("/");
                    }
                    else
                    {
                        return RedirectToAction("Create", "Empresas");
                    }
                }
            }
            else
            {
                ViewBag.Message = "Usuário ou senha inválidos!";
            }

            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Usuarios");
        }


        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("UsuarioId,Email,Senha,TipoUsuario")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {

                var existingUser = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);

                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "O e-mail já está em uso.");
                    return View(usuario);
                }

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));


            if (usuario.UsuarioId != usuarioId)
            {
 
                return Forbid();
            }

            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioId,Email,Senha,TipoUsuario")] Usuario usuario)
        {
            if (id != usuario.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.UsuarioId))
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
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));


            if (usuario.UsuarioId != usuarioId)
            {

                return Forbid();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'AppDbContext.Usuarios' is null.");
            }

            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.UsuarioId == id);
        }
    }
}
