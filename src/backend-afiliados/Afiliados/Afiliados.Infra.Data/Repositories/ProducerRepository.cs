using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;

namespace Afiliados.Infra.Data.Repositories
{
	public class ProducerRepository : Repository<Producer>, IProducerRepository
	{
		public ProducerRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
