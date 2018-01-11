using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroSite.Models
{
    public class Livro
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Título")]
        [StringLength(50, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Autor { get; set; }

        [Display(Name = "Preço")]
        public decimal? Preco { get; set;  }

        public int? Quantidade { get; set; }
    }
}