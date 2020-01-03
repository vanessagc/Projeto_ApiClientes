using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.Models;

namespace Projeto.Application.Adapters
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

            CreateMap<Cliente, ClienteCadastroModel>();

            CreateMap<Endereco, EnderecoCadastroModel>();

            CreateMap<Cliente, ClienteEdicaoModel>()
               .AfterMap((de, para)
                    => para.IdCliente = de.IdCliente.ToString());

            CreateMap<Endereco, EnderecoEdicaoModel>()
                .AfterMap((de, para)
                    => para.IdEndereco = de.IdEndereco.ToString())
                .AfterMap((de, para)
                    => para.IdCliente = de.IdEndereco.ToString());
        }
    }
}
