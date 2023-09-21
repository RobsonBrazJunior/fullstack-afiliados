using Afiliados.Application.Interfaces;
using Afiliados.Application.ViewModels;
using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using AutoMapper;

namespace Afiliados.Application.Services
{
	public class ProducerService : IProducerService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public ProducerService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public ProducerViewModel Get(Guid id)
		{
			return _mapper.Map<ProducerViewModel>(_unitOfWork.ProducerRepository.Get(id));
		}

		public void Add(ProducerViewModel producer)
		{
			_unitOfWork.ProducerRepository.Add(_mapper.Map<Producer>(producer));
			_unitOfWork.Save();
		}

		public void Update(ProducerViewModel producer)
		{
			_unitOfWork.ProducerRepository.Update(_mapper.Map<Producer>(producer));
			_unitOfWork.Save();
		}

		public void Remove(ProducerViewModel producer)
		{
			_unitOfWork.ProducerRepository.Remove(_mapper.Map<Producer>(producer));
			_unitOfWork.Save();
		}
	}
}
