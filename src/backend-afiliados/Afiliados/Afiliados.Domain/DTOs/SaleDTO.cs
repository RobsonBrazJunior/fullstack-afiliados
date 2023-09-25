using System.ComponentModel.DataAnnotations;

namespace Afiliados.Domain.DTOs
{
	public class SaleDTO
	{
		[Required(ErrorMessage = "A Type is Required")]
		public byte Type { get; set; }

		[Required(ErrorMessage = "A Date is Required")]
		public DateTime Date { get; set; }

		[Required(ErrorMessage = "A Product is Required")]
		public string Product { get; set; }

		[Required(ErrorMessage = "A Value is Required")]
		public int Value { get; set; }

		[Required(ErrorMessage = "A Seller is Required")]
		public string Seller { get; set; }
	}
}
