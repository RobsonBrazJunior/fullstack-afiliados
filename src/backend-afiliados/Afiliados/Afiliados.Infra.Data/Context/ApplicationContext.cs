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

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Afiliados;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		public DbSet<Producer> Producers { get; set; }
		public DbSet<Affiliated> Affiliateds { get; set; }
	}
}
