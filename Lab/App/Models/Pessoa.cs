
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do usuário")]
        public int PessoaId { get; set; }

        [Display(Name = "Nome do usuário")]
        public string Nome { get; set; }

        [Display(Name = "Tipo de usuário")]
        public string Tipo { get; set; }
    }
}