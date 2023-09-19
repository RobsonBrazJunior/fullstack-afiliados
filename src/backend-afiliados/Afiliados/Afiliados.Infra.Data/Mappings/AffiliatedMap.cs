using Afiliados.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afiliados.Infra.Data.Mappings
{
	public class AffiliatedMap : IEntityTypeConfiguration<Affiliated>
	{
		public void Configure(EntityTypeBuilder<Affiliated> builder)
		{
			builder.ToTable("Affiliateds");
			builder.HasKey(affiliated => affiliated.Id);
			builder.Property(affiliated => affiliated.Name).HasColumnType("VARCHAR(100)").IsRequired();

			builder.HasOne(affiliated => affiliated.Producer)
				.WithMany(producer => producer.Affiliateds)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
