using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Contracts
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
