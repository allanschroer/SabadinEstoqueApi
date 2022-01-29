using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SabadinEstoqueApi.Aplicacao;
using SabadinEstoqueApi.Dominio;
using SabadinEstoqueApi.Infra;

namespace SabadinEstoqueApi
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
            services.AddScoped<IProdutoAplicacao, ProdutoAplicacao>();
            services.AddScoped<IProdutoModeloRepositorio, ProdutoRepositorio>();
            services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddScoped<ICategoriaAplicacao, CategoriaAplicacao>();
            services.AddControllers();

            //Igorar camel case
            services.AddMvc(setupAction =>
            {
                setupAction.EnableEndpointRouting = false;
            }).AddJsonOptions(jsonOptions =>
            {
                jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;
                jsonOptions.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            });

            //AutoMapper das calsses
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProdutoModelo, Produto>();
                cfg.CreateMap<Produto, ProdutoModelo>();
                cfg.CreateMap<Categoria, CategoriaModelo>();
                cfg.CreateMap<CategoriaModelo,Categoria>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            //SWAGGER
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SabadinEstoqueApi", Version = "v1" });
            });
            services.AddDbContext<Context>(options => options.UseNpgsql(Configuration.GetConnectionString("Default")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SabadinEstoqueApi v1"));
            }
            app.UseHttpsRedirection();

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
