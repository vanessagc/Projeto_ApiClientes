using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IClienteApplicationService: IDisposable
    {
        void Create(ClienteModel model);
        void Update(ClienteModel model);
        void Remove(Guid id);

        List<ClienteModel> SelectAll();
        ClienteModel SelectById(Guid id);
    }
}
