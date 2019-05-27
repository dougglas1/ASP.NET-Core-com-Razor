using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Materias
    {
        [Key]
        public int MateriaisId { get; set; }

        public string Nome { get; set; }
    }
}
