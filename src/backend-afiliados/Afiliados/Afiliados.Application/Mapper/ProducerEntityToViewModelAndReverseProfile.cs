using Afiliados.Application.ViewModels;
using Afiliados.Domain.Entities;
using AutoMapper;

namespace Afiliados.Application.Mapper
{
	public class ProducerEntityToViewModelAndReverseProfile : Profile
	{
		public ProducerEntityToViewModelAndReverseProfile()
		{
			CreateMap<Producer, ProducerViewModel>()
				.ForSourceMember(producer => producer.Affiliateds, memberOptions => memberOptions.DoNotValidate())
				.ReverseMap()
				.ForMember(producer => producer.Affiliateds, options => options.Ignore());
		}
	}
}
