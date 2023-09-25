using Afiliados.Domain.Entities;
using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;

namespace Afiliados.Infra.Data.Repositories
{
	public class SaleRepository : Repository<Sale>, ISaleRepository
	{
		public SaleRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
