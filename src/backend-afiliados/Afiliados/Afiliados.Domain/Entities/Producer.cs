namespace Afiliados.Domain.Entities
{
	public class Producer : BaseEntity
	{
		public string Name { get; set; }
		public ICollection<Affiliated> Affiliateds { get; set; }
	}
}
