using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;

namespace Afiliados.Infra.Data.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationContext _context;
		private readonly IProducerRepository _producerRepository;
		private readonly IAffiliatedRepository _affiliatedRepository;
		private readonly ISaleRepository _saleRepositoryy;

		public UnitOfWork(ApplicationContext context)
		{
			_context = context;
			_producerRepository = new ProducerRepository(context);
			_affiliatedRepository = new AffiliatedRepository(context);
			_saleRepositoryy = new SaleRepository(context);
		}

		public IProducerRepository ProducerRepository => _producerRepository;
		public IAffiliatedRepository AffiliatedRepository => _affiliatedRepository;
		public ISaleRepository SaleRepository => _saleRepositoryy;

		public int Save()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
