using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class IdosoViewComponent : ViewComponent
    {
        private readonly Contexto _pessoaContexto;

        public IdosoViewComponent(Contexto PessoaContexto)
        {
            _pessoaContexto = PessoaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _pessoaContexto.Pessoa.Where(x => x.Idade >= 60).ToListAsync());
        }
    }
}
