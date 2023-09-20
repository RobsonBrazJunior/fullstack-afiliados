using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;

namespace Afiliados.Infra.Data.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationContext _context;
		private readonly IProducerRepository _producerRepository;
		private readonly IAffiliatedRepository _affiliatedRepository;

		public UnitOfWork(ApplicationContext context)
		{
			_context = context;
			_producerRepository = new ProducerRepository(context);
			_affiliatedRepository = new AffiliatedRepository(context);
		}

		public IProducerRepository ProducerRepository { get { return _producerRepository; } }
		public IAffiliatedRepository AffiliatedRepository { get { return _affiliatedRepository; } }

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
