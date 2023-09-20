using FluentValidation;
using Afiliados.Domain.Entities;

namespace Afiliados.Domain.Validations
{
	public class AffiliatedValidation : AbstractValidator<Affiliated>
	{
		public AffiliatedValidation()
		{
			RuleFor(affiliated => affiliated.Name)
				.NotNull().NotEmpty().WithMessage("Name must be filled in!");
		}
	}
}
