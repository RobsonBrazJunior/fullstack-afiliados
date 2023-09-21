using Afiliados.Application.ViewModels;
using Afiliados.Domain.Entities;
using AutoMapper;

namespace Afiliados.Application.Mapper
{
	public class AffiliatedEntityToViewModelAndReverseProfile : Profile
	{
		public AffiliatedEntityToViewModelAndReverseProfile()
		{
			CreateMap<Affiliated, AffiliatedViewModel>()
				.ForSourceMember(affiliated => affiliated.Producer, memberOptions => memberOptions.DoNotValidate())
				.ReverseMap()
				.ForMember(affiliated => affiliated.Producer, options => options.Ignore());
		}
	}
}
