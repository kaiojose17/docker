using System.Collections.Generic;

namespace mvc.Models
{
    public class ProdutoRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]
        {
            new Produto { ProdutoId=10, Nome="Caneta", Categoria="Material", Preco=0.50M},
            new Produto { ProdutoId=20, Nome="Borracha", Categoria="Material", Preco=1.50M},
            new Produto { ProdutoId=30, Nome="Estojo", Categoria="Material", Preco=2.50M}
        };
        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}