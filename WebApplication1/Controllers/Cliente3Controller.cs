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
    public class Cliente3Controller : Controller
    {
        private readonly Contexto _context;

        public Cliente3Controller(Contexto context)
        {
            _context = context;
        }

        // GET: Cliente3
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cliente3.ToListAsync());
        }

        // GET: Cliente3/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente3 = await _context.Cliente3
                .FirstOrDefaultAsync(m => m.Cliente3Id == id);
            if (cliente3 == null)
            {
                return NotFound();
            }

            return View(cliente3);
        }

        // GET: Cliente3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cliente3Id,Nome,Idade")] Cliente3 cliente3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente3);
        }

        // GET: Cliente3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente3 = await _context.Cliente3.FindAsync(id);
            if (cliente3 == null)
            {
                return NotFound();
            }
            return View(cliente3);
        }

        // POST: Cliente3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cliente3Id,Nome,Idade")] Cliente3 cliente3)
        {
            if (id != cliente3.Cliente3Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cliente3Exists(cliente3.Cliente3Id))
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
            return View(cliente3);
        }

        // GET: Cliente3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente3 = await _context.Cliente3
                .FirstOrDefaultAsync(m => m.Cliente3Id == id);
            if (cliente3 == null)
            {
                return NotFound();
            }

            return View(cliente3);
        }

        // POST: Cliente3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente3 = await _context.Cliente3.FindAsync(id);
            _context.Cliente3.Remove(cliente3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cliente3Exists(int id)
        {
            return _context.Cliente3.Any(e => e.Cliente3Id == id);
        }
    }
}
