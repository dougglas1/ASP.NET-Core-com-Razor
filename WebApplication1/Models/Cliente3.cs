using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Validacao;

namespace WebApplication1.Models
{
    /// <summary>
    /// Usado para teste de Validação Personalizada
    /// </summary>
    public class Cliente3
    {
        public int Cliente3Id { get; set; }
        public string Nome { get; set; }

        [Adulto]
        public int Idade { get; set; }
    }
}
