using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Application.Services;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using Projeto.Infra.Data.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace Projeto.Presentation.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            AutoMapperConfig(services);

            
            services.AddSingleton<IClienteDomainService, ClienteDomainService>();
            services.AddSingleton<IEnderecoDomainService, EnderecoDomainService>();

            services.AddSingleton<IClienteApplicationService, ClienteApplicationService>();
            services.AddSingleton<IEnderecoApplicationService, EnderecoApplicationService>();

            services.AddSingleton<IClienteRepository, ClienteRepository>
                (map => new ClienteRepository(new ConcurrentDictionary<Guid, Cliente>()));
            services.AddSingleton<IEnderecoRepository, EnderecoRepository>
                (map => new EnderecoRepository(new ConcurrentDictionary<Guid, Endereco>()));

            #region Configuração do Swagger

            services.AddSwaggerGen(
                  swagger =>
                  {
                      swagger.SwaggerDoc("v1",
                          new Info
                          {
                              Title = "Sistema Asp.Net Web API - Cadastro de Clientes",
                              Version = "v1",
                              Description = "Desafio - Vanessa G Carvalho",
                              Contact = new Contact
                              {
                                  Name = "VANESSA G CARVALHO",
                                  Url = "http://www.vanessagcarvalho.com.br",
                                  Email = "vanessagc.info@gmail.com"
                              }
                          });
                  }
              );

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Configuração do Swagger

            app.UseSwagger();
            app.UseSwaggerUI(
                    swagger =>
                    {
                        swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "Projeto");
                    }
                );

            #endregion

            app.UseMvc();
        }

        private void AutoMapperConfig(IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteModel, Cliente>();
                cfg.CreateMap<Cliente, ClienteModel>();
                cfg.CreateMap<EnderecoModel, Endereco>();
                cfg.CreateMap<Endereco, EnderecoModel>();
                cfg.CreateMap<ClienteEnderecoModel, Cliente>();
                cfg.CreateMap<ClienteEnderecoModel, Endereco>();
                cfg.CreateMap<Cliente, ClienteEnderecoModel>();
                cfg.CreateMap<Endereco, ClienteEnderecoModel>();

            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
