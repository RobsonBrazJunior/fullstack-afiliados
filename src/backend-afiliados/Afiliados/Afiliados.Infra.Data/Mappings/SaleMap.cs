using Afiliados.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afiliados.Infra.Data.Mappings
{
	public class SaleMap : IEntityTypeConfiguration<Sale>
	{
		public void Configure(EntityTypeBuilder<Sale> builder)
		{
			builder.ToTable("Sales");
			builder.HasKey(sale => sale.Id);
			builder.Property(sale => sale.Date).HasConversion<DateTime>().IsRequired();
			builder.Property(sale => sale.Product).HasColumnType("VARCHAR(30)").IsRequired();
			builder.Property(sale => sale.Value).HasConversion<int>().IsRequired();
			builder.Property(sale => sale.Seller).HasColumnType("VARCHAR(20)").IsRequired();
		}
	}
}
