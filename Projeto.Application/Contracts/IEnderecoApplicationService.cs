using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IEnderecoApplicationService: IDisposable
    {
        void Create(EnderecoModel model);
        void Update(EnderecoModel model);
        void Remove(string id);

        List<EnderecoModel> SelectAll();
        EnderecoModel SelectById(string id);

    
    }
}
