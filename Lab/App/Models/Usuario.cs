using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
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
        [Remote("LoginUnico", "Usuario", ErrorMessage ="Login já existe na base de dados")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Somente letras")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha e a confirmação devem ser iguais")]
        [Display(Name = "Confirmar Senha")]
        public string ConfirmarSenha { get; set; }
    }
}