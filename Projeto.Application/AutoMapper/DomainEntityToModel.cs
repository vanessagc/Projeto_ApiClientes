using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.Models;

namespace Projeto.Application.AutoMapper
{
    public class DomainEntityToModel : Profile
    {
        public DomainEntityToModel()
        {

            CreateMap<Cliente, ClienteModel>();
            CreateMap<Endereco, EnderecoModel>();
        }
    }
}
