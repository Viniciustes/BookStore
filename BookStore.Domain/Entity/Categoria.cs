﻿using System.Collections.Generic;

namespace BookStore.Domain.Entity
{
    public class Categoria
    {
        public Categoria()
        {
            Livros = new List<Livro>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}