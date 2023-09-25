using Afiliados.Domain.DTOs;
using Afiliados.Domain.Entities;
using AutoMapper;

namespace Afiliados.Application.Mapper
{
	public class SaleEntityToDtoAndRevserProfile : Profile
	{
		public SaleEntityToDtoAndRevserProfile()
		{
			CreateMap<Sale, SaleDTO>().ReverseMap();
		}
	}
}
