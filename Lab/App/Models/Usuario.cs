using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [StringLength(50, MinimumLength = 5, 
            ErrorMessage = "Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Range(18, 70, ErrorMessage ="A idade deve ser de 18 a 70 anos")]
        public int? Idade { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", 
            ErrorMessage = "O e-mail informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [RegularExpression(@"[a-zA-Z]{5, 15}", 
            ErrorMessage = "Somente lentras, de 5 a 15 caracteres")]
       
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação devem serem iguais")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenha { get; set; }
    }
}