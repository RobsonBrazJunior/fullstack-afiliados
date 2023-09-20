using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;

namespace Afiliados.Infra.Data.Repositories
{
	public class AffiliatedRepository : Repository<Affiliated>, IAffiliatedRepository
	{
		public AffiliatedRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
