using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroSite.Models
{
    public class Pecas
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }

        public int? Quantidade { get; set; }

    }
}