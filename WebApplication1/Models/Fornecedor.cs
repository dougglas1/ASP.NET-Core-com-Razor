using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        
        public string Nome { get; set; }

        public int? Idade { get; set; }

        public double? Peso { get; set; }
    }
}
