using System;

namespace Product_Project.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public string TipoProduto { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}