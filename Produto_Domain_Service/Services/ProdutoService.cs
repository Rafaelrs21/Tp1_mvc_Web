using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Produto_Domain.Model.Interface.Repository;
using Produto_Domain.Model.Interface.Service;
using Produto_Domain.Model.Model;

namespace Produto_Domain_Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _IProdutoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _IProdutoRepository = produtoRepository;
        }

        public async Task Delete(int id)
        {
            await _IProdutoRepository.Delete(id);
        }

        public async Task Edit(ProdutoModel produto)
        {
            await _IProdutoRepository.Edit(produto);
        }

        public async Task<IEnumerable<ProdutoModel>> GetAll()
        {
           return await _IProdutoRepository.GetAll();
        }

        public async Task<ProdutoModel> GetById(int id)
        {
           return await _IProdutoRepository.GetById(id);
        }

        public async Task Insert(ProdutoModel produto)
        {
            await _IProdutoRepository.Insert(produto);
        }
    }
}