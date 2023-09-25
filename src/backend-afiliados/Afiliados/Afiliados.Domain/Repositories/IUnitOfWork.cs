namespace Afiliados.Domain.Repositories
{
	public interface IUnitOfWork : IDisposable
	{
		IProducerRepository ProducerRepository { get; }
		IAffiliatedRepository AffiliatedRepository { get; }
		ISaleRepository SaleRepository { get; }
		int Save();
	}
}
