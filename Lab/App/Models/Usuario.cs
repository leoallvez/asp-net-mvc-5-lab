using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace App.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Observacoes { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Confirmar { get; set; }
    }
}