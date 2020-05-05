using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Produto_Domain.Model.Model;

namespace Produto_Project.Data.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext (DbContextOptions<ProdutoContext> options)
            : base(options)
        {

        }
        public DbSet<ProdutoModel> Produto { get; set; }
    }
}