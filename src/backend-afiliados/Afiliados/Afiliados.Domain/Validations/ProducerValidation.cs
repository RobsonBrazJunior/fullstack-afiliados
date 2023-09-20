using FluentValidation;
using Afiliados.Domain.Entities;

namespace Afiliados.Domain.Validations
{
	public class ProducerValidation : AbstractValidator<Producer>
	{
		public ProducerValidation()
		{
			RuleFor(producer => producer.Name)
				.NotNull().NotEmpty().WithMessage("Name must be filled in!");
		}
	}
}
