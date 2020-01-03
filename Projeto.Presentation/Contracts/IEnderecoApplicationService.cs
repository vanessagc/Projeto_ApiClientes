using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Contracts
{
    public interface IEnderecoApplicationService: IDisposable
    {
        void Create(EnderecoCadastroModel model);
        void Update(EnderecoEdicaoModel model);
        void Remove(string id);

        List<EnderecoConsultaModel> SelectAll();
        EnderecoConsultaModel SelectById(string id);

    
    }
}
