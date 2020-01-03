using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IClienteApplicationService: IDisposable
    {
        ClienteEnderecoModel Create(ClienteEnderecoModel model);
        ClienteModel Update(ClienteModel model);
        void Remove(Guid id);

        List<ClienteModel> SelectAll();
        ClienteModel SelectById(Guid id);

        ClienteModel SelectByCpf(string Cpf);

    }
}
