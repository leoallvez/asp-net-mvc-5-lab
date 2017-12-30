using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public int Idade { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string Confirmar { get; set; }
    }
}