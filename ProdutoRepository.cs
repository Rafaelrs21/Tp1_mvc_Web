using System;

public class Class1
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task Delete(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public Task Edit(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }
    }
}
