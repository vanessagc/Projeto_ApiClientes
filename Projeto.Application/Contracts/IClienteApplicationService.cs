using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IClienteApplicationService: IDisposable
    {
        ClienteEnderecoModel Create(ClienteEnderecoModel model);
        ClienteEnderecoModel Update(ClienteEnderecoModel model);
        void Remove(Guid id);

        IEnumerable<ClienteEnderecoModel> SelectAll();
        ClienteEnderecoModel SelectById(Guid id);

        ClienteEnderecoModel SelectByCpf(string Cpf);

    }
}
