using Afiliados.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afiliados.Infra.Data.Mappings
{
	public class ProducerMap : IEntityTypeConfiguration<Producer>
	{
		public void Configure(EntityTypeBuilder<Producer> builder)
		{
			builder.ToTable("Producers");
			builder.HasKey(producer => producer.Id);
			builder.Property(producer => producer.Name).HasColumnType("VARCHAR(100)").IsRequired();
		}
	}
}
