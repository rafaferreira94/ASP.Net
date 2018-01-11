using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroSite.Models
{
    public class Categoria
    {
        [Key]
        public int IDCategoria { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        [StringLength(50, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Descricao { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}