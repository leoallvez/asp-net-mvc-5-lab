﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Noticia
    {
        [Required(ErrorMessage = "Obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        public string Categoria { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Conteudo { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            return new Collection<Noticia>
                {
                    new Noticia
                        {
                            Id = 1,
                            Categoria = "Esportes",
                            Titulo = "Felipe Massa ganha F1",
                            Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 2,
                            Categoria = "Política",
                            Titulo = "Presidente assina convênios",
                            Conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 3,
                            Categoria = "Política",
                            Titulo = "Vereador é eleito pela 4ª vez",
                            Conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 4,
                            Categoria = "Esportes",
                            Titulo = "O tão sonhado titulo chegou",
                            Conteudo = "Em um jogo que levou os torcedores ao delirio...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 5,
                            Categoria = "Humor",
                            Titulo = "O Comediante Anderson Renato fará shou hoje",
                            Conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 6,
                            Categoria = "Policial",
                            Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                            Conteudo = "Durante a retomada do morro o tenente coronel disse...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 7,
                            Categoria = "Esportes",
                            Titulo = "Atacante do Barcelona faz 4 gols",
                            Conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o titulo...",
                            Data = new DateTime(2017,3,1)
                        }
                };
        }
    }
}
   