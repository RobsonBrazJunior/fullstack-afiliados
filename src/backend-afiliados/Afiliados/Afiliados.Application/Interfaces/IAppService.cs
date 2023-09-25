namespace Afiliados.Application.Interfaces
{
	public interface IAppService<T> where T : class
	{
		T Get(Guid id);
		IEnumerable<T> GetAll();
		void Add(T obj);
		void AddRange(IEnumerable<T> entities);
		void Update(T obj);
		void Remove(T obj);
	}
}
