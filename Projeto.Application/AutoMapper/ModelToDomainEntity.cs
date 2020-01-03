using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.Models;
using System;

namespace Projeto.Application.AutoMapper
{
    public class ModelToDomainEntity: Profile
    {
        public ModelToDomainEntity()
        {

            CreateMap<ClienteModel, Cliente>();
            CreateMap<EnderecoModel, Endereco>();
        }

    }
}
