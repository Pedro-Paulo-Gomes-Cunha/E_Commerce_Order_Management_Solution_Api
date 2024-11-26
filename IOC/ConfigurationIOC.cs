using Autofac;
using Data.Repositories;
using Domain.DBOs.IServices;
using Domain.Interfaces.IRepositories;
using Domain.IRepositories;
using Domain.IServices;
using Domain.Repositories;
using Domain.Services;

namespace IOC
{
	public class ConfigurationIOC
	{


		public static void Load(ContainerBuilder builder)
		{
			#region IOC*/
			/*  builder.RegisterGeneric(typeof(ServiceBase<>))
				 .As(typeof(IServiceBase<>))
				 .InstancePerLifetimeScope();*/

			builder.RegisterGeneric(typeof(BaseRepository<>))
			   .As(typeof(IBaseRepository<>))
			   .InstancePerLifetimeScope();

			builder.RegisterType<WrapperRepossitory>().As<IWrapperRepossitory>();

			//client
			builder.RegisterType<ClientService>().As<IClientService>();
			builder.RegisterType<ClientRepository>().As<IClientRepository>();
			
			//order
			builder.RegisterType<OrderService>().As<IOrderService>();
			builder.RegisterType<OrderRepository>().As<IOrderRepository>();
			
			//product
			builder.RegisterType<ProductService>().As<IProductService>();
			builder.RegisterType<ProductRepository>().As<IProductRepository>();
			
			//orderpruduct
			//builder.RegisterType<OrderProductService>().As<IOrderProductService>(); //not implemented
			builder.RegisterType<OrderProductRepository>().As<IOrderProductRepository>();

			#endregion IOC


		}

	}

}
