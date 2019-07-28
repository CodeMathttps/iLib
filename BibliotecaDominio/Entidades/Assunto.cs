﻿using System.Collections.Generic;

namespace BibliotecaDominio
{
    public class Assunto
    {
        public int AssuntoId { get; set; }
        public string AssuntoObra { get; internal set; }
        public IEnumerable<Livro> Livros { get; internal set; } //Relação um para muitos (um assunto - muitos livros)
    }
}