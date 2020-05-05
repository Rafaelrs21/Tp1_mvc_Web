using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Produto_Domain.Model.Interface.Repository;
using Produto_Domain.Model.Model;
using Produto_Project.Data.Context;

namespace Infastructure.Data.Repository
{
    
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext produtoContext)
        {
            _context = produtoContext;
        }

        public ProdutoContext ProdutoContext { get; }

        public async Task Delete(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(ProdutoModel produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProdutoModel>> GetAll()
        {
           return await _context.Produto.ToListAsync();
        }

        public async Task<ProdutoModel> GetById(int id)
        {
            return await _context.Produto.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(ProdutoModel produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
        }
    }
}