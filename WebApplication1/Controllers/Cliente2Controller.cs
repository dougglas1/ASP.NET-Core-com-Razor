using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Cliente2Controller : Controller
    {
        private readonly Contexto _context;

        public Cliente2Controller(Contexto context)
        {
            _context = context;
        }

        public async Task<JsonResult> ClienteExisteAsync(string nome)
        {
            if (await _context.Cliente2.AnyAsync(x => x.Nome.Equals(nome)))
                return Json("Usuário já existe");

            return Json(true);
        }

        // GET: Cliente2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente2.ToListAsync());
        }

        // GET: Cliente2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente2 = await _context.Cliente2
                .FirstOrDefaultAsync(m => m.Clente2Id == id);
            if (cliente2 == null)
            {
                return NotFound();
            }

            return View(cliente2);
        }

        // GET: Cliente2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Clente2Id,Nome,Idade")] Cliente2 cliente2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente2);
        }

        // GET: Cliente2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente2 = await _context.Cliente2.FindAsync(id);
            if (cliente2 == null)
            {
                return NotFound();
            }
            return View(cliente2);
        }

        // POST: Cliente2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Clente2Id,Nome,Idade")] Cliente2 cliente2)
        {
            if (id != cliente2.Clente2Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cliente2Exists(cliente2.Clente2Id))
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
            return View(cliente2);
        }

        // GET: Cliente2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente2 = await _context.Cliente2
                .FirstOrDefaultAsync(m => m.Clente2Id == id);
            if (cliente2 == null)
            {
                return NotFound();
            }

            return View(cliente2);
        }

        // POST: Cliente2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente2 = await _context.Cliente2.FindAsync(id);
            _context.Cliente2.Remove(cliente2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cliente2Exists(int id)
        {
            return _context.Cliente2.Any(e => e.Clente2Id == id);
        }
    }
}
