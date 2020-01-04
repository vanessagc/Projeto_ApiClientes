using AutoMapper;
using Projeto.Application.Models;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Mappings
{
    public class ViewModelToEntityMap: Profile
    {
        public ViewModelToEntityMap()
        {
            CreateMap<ClienteModel,Cliente>();
            CreateMap<ClienteEnderecoModel,Cliente>();
            CreateMap<EnderecoModel,Endereco>();
            CreateMap<ClienteEnderecoModel,Endereco>();

        }


    }
}
