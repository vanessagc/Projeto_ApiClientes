using AutoMapper;
using Projeto.Application.Models;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
    public class EntityToViewModelMap:Profile
    {
        public EntityToViewModelMap()
        {
            CreateMap<Cliente, ClienteModel>();
            CreateMap<Cliente, ClienteEnderecoModel>();
            CreateMap<Endereco, EnderecoModel>();
            CreateMap<Endereco, ClienteEnderecoModel>();
        }
    }
}
