using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class TodosViewModel
    {
        public IEnumerable<Alunos> Alunos { get; set; }
        public IEnumerable<Materias> Materias { get; set; }
    }
}
