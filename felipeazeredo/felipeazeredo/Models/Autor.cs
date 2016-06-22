﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace felipeazeredo.Models
{
    [Table("autores")]
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 20, ErrorMessage = "O Nome deve ter entre 20 e 100 caracteres")]
        [Required]
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}