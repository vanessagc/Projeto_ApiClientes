using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Adapters
{
    public class DomainEntityToModel : Profile
    {
        public DomainEntityToModel()
        {
            CreateMap<Cliente, ClienteConsultaModel>()
               .AfterMap((de, para)
                    => para.IdCliente = de.IdCliente.ToString());

            CreateMap<Endereco, EnderecoConsultaModel>()
                .AfterMap((de, para)
                    => para.IdEndereco = de.IdEndereco.ToString())
                .AfterMap((de, para)
                    => para.IdCliente = de.IdEndereco.ToString());
        }
    }
}
