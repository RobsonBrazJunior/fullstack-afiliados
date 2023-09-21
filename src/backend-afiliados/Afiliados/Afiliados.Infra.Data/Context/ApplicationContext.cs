using Afiliados.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Afiliados.Infra.Data.Context
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext()
		{
		}

		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		public DbSet<Producer> Producers { get; set; }
		public DbSet<Affiliated> Affiliateds { get; set; }
	}
}
