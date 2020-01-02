using AutoMapper;
using Projeto.Infra.Data.Entities;
using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Mappings
{
    public class ClienteMap: Profile
    {
        public ClienteMap()
        {
            CreateMap<ClienteCadastroModel, Cliente>()
                            .AfterMap((src, dest) => dest.IdCliente = Guid.NewGuid());

            CreateMap<ClienteEdicaoModel, Cliente>();

           
        }
    }
}
