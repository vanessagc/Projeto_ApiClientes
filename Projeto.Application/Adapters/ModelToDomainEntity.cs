using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.Models;
using System;

namespace Projeto.Application.Adapters
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
