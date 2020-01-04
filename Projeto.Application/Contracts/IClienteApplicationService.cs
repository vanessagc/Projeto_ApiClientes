using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IClienteApplicationService: IDisposable
    {
        ClienteModel Create(ClienteModel model);
        ClienteModel Update(ClienteModel model);
        void Remove(ClienteModel model);
        IEnumerable<ClienteModel> SelectAll();
        ClienteModel SelectById(Guid id);
        ClienteModel SelectByCpf(string Cpf);
        ClienteModel SelectByNome(string nome);
    }
}
