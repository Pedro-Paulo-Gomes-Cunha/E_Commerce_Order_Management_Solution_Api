using Domain.DBOs;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
	public class Context_Ecommerce: DbContext
	{
		public Context_Ecommerce() : base()
		{
		}
		public Context_Ecommerce(DbContextOptions<DbContext> options) : base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var stringConexao = GetConnectionString();
			options.UseSqlServer(stringConexao);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			/* modelBuilder.Entity<PerformanceSheetDB>()
                .HasOne(d => d.CourseDB)
                .WithMany()
                .OnDelete(DeleteBehavior.DeleteBehavior.NoAction);*/

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<OrderDbo> orders { get; set; }
		public DbSet<ClientDbo> clients{ get; set; }
		public DbSet<ProductDbo> produts { get; set; }
		public DbSet<OrderProductDbo> order_products{ get; set; }

		private static string GetConnectionString()
		{
			string settingsFileName;
			//#if DEBUG
			//   settingsFileName = "appsettings.json"; 
			//#else
			settingsFileName = "appsettings.json";
			//#endif
			var settings = JObject.Parse(File.ReadAllText(settingsFileName));
			return settings["ConnectionString"].ToString();
		}
	}
	
}
