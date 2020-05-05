using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Produto_Domain.Model.Model
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        [Required]
        public string NomeProduto { get; set; }
        [Required]
        public string TipoProduto { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
    }
}