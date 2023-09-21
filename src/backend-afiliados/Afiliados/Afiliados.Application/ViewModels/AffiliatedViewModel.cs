using System.ComponentModel.DataAnnotations;

namespace Afiliados.Application.ViewModels
{
	public class AffiliatedViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "The Name is Required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "A producer is Required")]
		public Guid ProducerId { get; set; }
	}
}
