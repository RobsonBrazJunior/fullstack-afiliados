namespace Afiliados.Domain.Entities
{
	public abstract class BaseEntity
	{
		public Guid Id { get; private init; } = Guid.NewGuid();
	}
}
