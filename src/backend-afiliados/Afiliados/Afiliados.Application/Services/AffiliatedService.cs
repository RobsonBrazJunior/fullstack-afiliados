﻿using Afiliados.Application.Interfaces;
using Afiliados.Application.ViewModels;
using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using AutoMapper;

namespace Afiliados.Application.Services
{
	public class AffiliatedService : IAffiliatedService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public AffiliatedService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public AffiliatedViewModel Get(Guid id)
		{
			return _mapper.Map<AffiliatedViewModel>(_unitOfWork.AffiliatedRepository.Get(id));
		}

		public IEnumerable<AffiliatedViewModel> GetAll()
		{
			return _mapper.Map<IEnumerable<AffiliatedViewModel>>(_unitOfWork.AffiliatedRepository.GetAll());
		}

		public void Add(AffiliatedViewModel affiliated)
		{
			_unitOfWork.AffiliatedRepository.Add(_mapper.Map<Affiliated>(affiliated));
			_unitOfWork.Save();
		}

		public void AddRange(IEnumerable<AffiliatedViewModel> entities)
		{
			_unitOfWork.AffiliatedRepository.AddRange(_mapper.Map<IEnumerable<Affiliated>>(entities));
			_unitOfWork.Save();
		}

		public void Update(AffiliatedViewModel affiliated)
		{
			_unitOfWork.AffiliatedRepository.Add(_mapper.Map<Affiliated>(affiliated));
			_unitOfWork.Save();
		}

		public void Remove(AffiliatedViewModel affiliated)
		{
			_unitOfWork.AffiliatedRepository.Add(_mapper.Map<Affiliated>(affiliated));
			_unitOfWork.Save();
		}
	}
}
