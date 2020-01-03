﻿using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService _domainService;
        private readonly IMapper _mapper;

        public EnderecoApplicationService()
        {
        }
        public EnderecoModel Create(EnderecoModel model)
        {
            var endereco = _mapper.Map<Endereco>(model);
            Endereco enderecoRetorno;

                enderecoRetorno = _domainService.Create(endereco);
                model = _mapper.Map<EnderecoModel>(enderecoRetorno);

            return model;
        }

        public void Dispose()
        {
            _domainService.Dispose();
        }

        public void Remove(Guid id)
        {
            _domainService.Remove(id);
        }

        public List<EnderecoModel> SelectAll()
        {
            var model = _mapper.Map<List<EnderecoModel>>(_domainService.SelectAll());
            return model;
        }

        public EnderecoModel SelectById(Guid id)
        {
            var model = _mapper.Map<EnderecoModel>(_domainService.SelectById(id));
            return model;
        }

        public EnderecoModel Update(EnderecoModel model)
        {
            var endereco = _mapper.Map<Endereco>(model);
            _domainService.Update(endereco);
            model = _mapper.Map<EnderecoModel>(endereco);

            return model;
        }
    }
}
