using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// Usado para teste de Validação Remota
    /// </summary>
    public class Cliente2
    {
        [Key]
        public int Clente2Id { get; set; }

        [Remote("ClienteExisteAsync","Cliente")]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
