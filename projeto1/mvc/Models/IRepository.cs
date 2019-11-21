using System.Collections.Generic;

namespace mvc.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos { get; }         
    }
}