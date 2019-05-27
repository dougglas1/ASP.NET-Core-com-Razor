 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [Table("Pessoa1")]
    public class Person
    {
        [Key]
        [Column("PessoaId", TypeName ="int")]
        [Display(Name = "Seu ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Gerado pelo Usuário
        public int PersonId { get; set; }

        [Column("Nome", TypeName = "ntext")]
        [Display(Name="Seu Nome")]
        public string Name { get; set; }

        [Column("CPF", TypeName = "ntext")]
        [Display(Name = "Cadastro de Pessoa Física")]
        public string CPF { get; set; }

        [Column("Nascimento", TypeName = "date")]
        [Display(Name = "Sua Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Column("Idade", TypeName = "int")]
        [Display(Name = "Sua Idade")]
        public int Age { get; set; }
    }
}
