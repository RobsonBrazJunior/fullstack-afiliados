namespace Afiliados.Domain.Repositories
{
	public interface IRepository<T> where T : class
	{
		T Get(Guid id);
		void Add(T entity);
		void Update(T entity);
		void Remove(T entity);
	}
}
