using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Produto_Domain.Model.Model;

namespace Produto_Domain.Model.Interface.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoModel>> GetAll();

        Task<ProdutoModel> GetById(int id);

        Task Insert(ProdutoModel produto);

        Task Delete(int id);

        Task Edit(ProdutoModel produto);
    }
}
