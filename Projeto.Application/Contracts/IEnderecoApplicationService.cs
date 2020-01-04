using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IEnderecoApplicationService: IDisposable
    {
        EnderecoModel Create(EnderecoModel model);
        EnderecoModel Update(EnderecoModel model);
        void Remove(EnderecoModel model);

        IEnumerable<EnderecoModel> SelectAll();
        EnderecoModel SelectById(Guid id);

    
    }
}
