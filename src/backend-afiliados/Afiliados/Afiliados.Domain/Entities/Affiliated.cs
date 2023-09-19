namespace Afiliados.Domain.Entities
{
	public class Affiliated : BaseEntity
	{
		public string Name { get; set; }
		public Producer Producer { get; set; }
	}
}
