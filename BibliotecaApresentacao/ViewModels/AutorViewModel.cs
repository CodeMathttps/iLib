﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaApresentacao.ViewModels
{
    public class AutorViewModel
    {
        [Key]
        public int AutorId { get; set; }
        [Required(ErrorMessage = "Nome do Autor é obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres.")]
        public string NomeAutor { get; set; }
        public virtual IEnumerable<LivroViewModel> Livros { get; set; }
    }
}