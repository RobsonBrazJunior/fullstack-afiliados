namespace Afiliados.Domain.Entities
{
	public class Sale : BaseEntity
	{
		public byte Type { get; set; }
		public DateTime Date { get; set; }
		public string Product { get; set; }
		public int Value { get; set; }
		public string Seller { get; set; }
	}
}
