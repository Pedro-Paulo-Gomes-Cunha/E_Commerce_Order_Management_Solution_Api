using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Autofac;
using Data.Context;
using IOC;

//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.OpenApi.Models;

namespace E_Comerce_Web_Api
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
			services.AddDbContext<Context_Ecommerce>();
			services.AddControllers();
			// services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ecommerce.API", Version = "v1" });
			});

		}

		public void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterModule(new ModuleIOC());
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseCors(builder => builder
						 .AllowAnyOrigin()
						 .AllowAnyMethod()
						 .AllowAnyHeader());


			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce.API");
			});

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
