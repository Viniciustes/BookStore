﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Autor
    {
        public Autor()
        {
            Livros = new List<Livro>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(maximumLength: 30, MinimumLength = 3, ErrorMessage = "Campo Inválido")]
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}