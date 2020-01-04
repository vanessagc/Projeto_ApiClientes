using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {

        private readonly DataContext dataContext;
        public EnderecoRepository(DataContext dataContext)
        : base(dataContext)
        {
            this.dataContext = dataContext;
        }

       
    }
}
