using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Presentation.Api.Models;
using System;

namespace Projeto.Presentation.Api.Adapters
{
    public class ModelToDomainEntity: Profile
    {
        public ModelToDomainEntity()
        {

            CreateMap<ClienteCadastroModel, Cliente>()
               .AfterMap((de, para)
                   => para.IdCliente = Guid.NewGuid());

            CreateMap<ClienteEdicaoModel, Cliente>()
                    .AfterMap((de, para)
                        => para.IdCliente = Guid.Parse(de.IdCliente));

            CreateMap<EnderecoCadastroModel, Endereco>()
                    .AfterMap((de, para)
                        => para.IdEndereco = Guid.NewGuid())
                    .AfterMap((de, para)
                        => para.IdCliente = Guid.Parse(de.IdCliente));

            CreateMap<EnderecoEdicaoModel, Endereco>()
                    .AfterMap((de, para)
                        => para.IdEndereco = Guid.Parse(de.IdEndereco))
                    .AfterMap((de, para)
                        => para.IdCliente = Guid.Parse(de.IdCliente));
        }
       
    }
}
