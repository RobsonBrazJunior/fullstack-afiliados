using System.ComponentModel.DataAnnotations;

namespace Afiliados.Application.ViewModels
{
	public class ProducerViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "The Name is Required")]
		public string Name { get; set; }
	}
}
