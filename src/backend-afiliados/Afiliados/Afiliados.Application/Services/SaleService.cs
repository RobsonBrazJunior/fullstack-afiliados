using Afiliados.Application.Interfaces;
using Afiliados.Domain.DTOs;
using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using AutoMapper;

namespace Afiliados.Application.Services
{
	public class SaleService : ISaleService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public SaleService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public SaleDTO Get(Guid id)
		{
			return _mapper.Map<SaleDTO>(_unitOfWork.SaleRepository.Get(id));
		}

		public IEnumerable<SaleDTO> GetAll()
		{
			return _mapper.Map<IEnumerable<SaleDTO>>(_unitOfWork.AffiliatedRepository.GetAll());
		}

		public void Add(SaleDTO sale)
		{
			_unitOfWork.SaleRepository.Add(_mapper.Map<Sale>(sale));
			_unitOfWork.Save();
		}

		public void AddRange(IEnumerable<SaleDTO> entities)
		{
			_unitOfWork.SaleRepository.AddRange(_mapper.Map<IEnumerable<Sale>>(entities));
			_unitOfWork.Save();
		}

		public void Update(SaleDTO sale)
		{
			_unitOfWork.SaleRepository.Update(_mapper.Map<Sale>(sale));
			_unitOfWork.Save();
		}

		public void Remove(SaleDTO sale)
		{
			_unitOfWork.SaleRepository.Remove(_mapper.Map<Sale>(sale));
			_unitOfWork.Save();
		}
	}
}
