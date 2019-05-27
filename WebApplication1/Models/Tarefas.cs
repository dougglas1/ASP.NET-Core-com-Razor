using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tarefas
    {
        public string TarefasId { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Importancia { get; set; }
    }
}
