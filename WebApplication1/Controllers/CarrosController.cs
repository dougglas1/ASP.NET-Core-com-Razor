using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarrosController : Controller
    {
        private readonly Contexto _contexto;

        public CarrosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Abrir Tela Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {            
            return View(_contexto.Carros.ToList());
        }

        /// <summary>
        /// Abrir Novo Carro
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NovoCarro()
        {
            return View();
        }

        /// <summary>
        /// Salvar na Tela Novo Carro
        /// </summary>
        /// <param name="carro"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoCarro(Carro carro)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(carro);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(carro);
        }

        /// <summary>
        /// Abrir Tela Atualiza Carro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AtualizaCarro(int? id)
        {
            if (id.Equals(null))
                return NotFound();

            var carro = _contexto.Carros.Find(id);

            return View(carro);
        }

        /// <summary>
        /// Atualizar na Tela Atualiza Carro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="carro"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AtualizaCarro(int id, Carro carro)
        {
            if (id.Equals(null))
                return NotFound();

            if (ModelState.IsValid)
            {
                _contexto.Update(carro);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(carro);
        }

        /// <summary>
        /// Abrir Tela Detalhes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Detalhes(int? id)
        {
            if (id.Equals(null))
                return NotFound();
            
            var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId.Equals(id));

            return View(carro);
        }

        /// <summary>
        /// Abrir Tela Exclui Carro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id.Equals(null))
                return NotFound();

            var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId.Equals(id));

            return View(carro);
        }

        /// <summary>
        /// Excluir na Tela Excluir Carro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarExclusao(int id)
        {
            if (id.Equals(null))
                return NotFound();

            var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId.Equals(id));
            _contexto.Remove(carro);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}