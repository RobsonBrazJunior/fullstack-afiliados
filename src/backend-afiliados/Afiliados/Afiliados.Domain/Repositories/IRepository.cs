namespace Afiliados.Domain.Repositories
{
	public interface IRepository<T> where T : class
	{
		T Get(Guid id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void AddRange(IEnumerable<T> entities);
		void Update(T entity);
		void Remove(T entity);
	}
}
