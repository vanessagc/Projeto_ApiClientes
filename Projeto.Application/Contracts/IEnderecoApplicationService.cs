using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
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
