using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroSite.Models
{
    public class Produto
    {
        [Key]
        public int IDProduto { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [DisplayFormat(DataFormatString = "{0:n2}",
            ApplyFormatInEditMode =true,
            NullDisplayText ="informe o preço")]
        [Range(1, 100000, ErrorMessage ="O preço deverá estar entre {0} e {1}")]
        public decimal? Preco { get; set; }

        [Display(Name = "Quantidade")]
        public int? QuantidadeEstoque { get; set; }

        [Display(Name = "Caminho Imagem")]
        [StringLength(200, ErrorMessage = "O máximo de caracteres permitido é {0}")]
        public string Imagem { get; set; }

        [Display(Name = "Categoria")]
        public int? IDCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}