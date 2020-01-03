using Projeto.Application.Models;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Contracts
{
    public interface IClienteApplicationService: IDisposable
    {
        void Create(ClienteCadastroModel model);
        void Update(ClienteEdicaoModel model);
        void Remove(string id);

        List<ClienteConsultaModel> SelectAll();
        ClienteConsultaModel SelectById(string id);
    }
}
