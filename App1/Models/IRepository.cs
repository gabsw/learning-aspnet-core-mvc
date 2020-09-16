using System.Linq;

namespace App1.Models
{
    public class IRepository
    {
        public IQueryable<Produto> Produtos {get; }
    }
}