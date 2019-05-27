using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly Contexto _moedaContexto;

        public MoedasViewComponent(Contexto MoedaContexto)
        {
            _moedaContexto = MoedaContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _moedaContexto.Moedas.ToListAsync());
        }
    }
}
