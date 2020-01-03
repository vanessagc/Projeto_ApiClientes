using AutoMapper;
using Projeto.Application.Models;
using Projeto.Domain.Entities;
using System;

namespace Projeto.Application.Mappings
{
    public class ClienteMap: Profile
    {
        public ClienteMap()
        {
            CreateMap<ClienteCadastroModel, Cliente>()
                            .AfterMap((src, dest) => dest.IdCliente = Guid.NewGuid());

            CreateMap<ClienteEdicaoModel, Cliente>();

            CreateMap<Cliente, ClienteConsultaModel>();

        }
    }
}
