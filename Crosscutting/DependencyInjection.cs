using Infastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Produto_Domain.Model.Interface.Repository;
using Produto_Domain.Model.Interface.Service;
using Produto_Domain_Service.Services;
using Produto_Project.Data.Context;
namespace Crosscutting
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProdutoContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Context")));

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
        }
    }
}
