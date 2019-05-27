using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// Usado para teste de Validação de Data Annotations
    /// </summary>
    public class Cliente
    {        
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(20, ErrorMessage = "Campo muito longo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 90, ErrorMessage = "Idade Inválida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Campo muito longo")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Campo muito longo")]
        [Compare("Email")]
        public string ConfirmarEmail { get; set; }
    }
}
