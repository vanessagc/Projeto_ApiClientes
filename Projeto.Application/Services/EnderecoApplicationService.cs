using AutoMapper;
using FluentValidation;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using Projeto.Domain.Validations;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService _domainService;
        private readonly IMapper _mapper;
        private readonly EnderecoEhValido _validator;

        public EnderecoApplicationService(IEnderecoDomainService domainService, IMapper mapper, EnderecoEhValido validator)
        {
            this._domainService = domainService;
            this._mapper = mapper;
            this._validator = validator;
        }
        public EnderecoModel Create(EnderecoModel model)
        {
            var endereco = _mapper.Map<Endereco>(model);

            var result = _validator.Validate(endereco, ruleSet: "all");

            endereco.ValidationResult = result;

            if (result.IsValid)
            {
                var enderecoRetorno = _domainService.Create(endereco);
                model = _mapper.Map<EnderecoModel>(enderecoRetorno);
            }

            return model;
        }

        public void Dispose()
        {
            _domainService.Dispose();
        }

        public void Remove(EnderecoModel model)
        {
            var endereco = _mapper.Map<Endereco>(model);

            _domainService.Remove(endereco);
        }

        public IEnumerable<EnderecoModel> SelectAll()
        {
            var model = _mapper.Map<IEnumerable<EnderecoModel>>(_domainService.SelectAll());
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

            var result = _validator.Validate(endereco, ruleSet: "all");

            endereco.ValidationResult = result;

            if (result.IsValid)
            {
                _domainService.Update(endereco);
                model = _mapper.Map<EnderecoModel>(endereco);
            }
            return model;
        }

    }
}
