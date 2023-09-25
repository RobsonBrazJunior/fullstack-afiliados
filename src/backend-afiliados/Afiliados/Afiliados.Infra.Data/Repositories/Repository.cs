using Afiliados.Domain.Repositories;
using Afiliados.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Afiliados.Infra.Data.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ApplicationContext _context;
		private readonly DbSet<T> DbSet;

		public Repository(ApplicationContext context)
		{
			_context = context;
			DbSet = _context.Set<T>();
		}

		public T Get(Guid id)
		{
			return DbSet.Find(id);
		}

		public IEnumerable<T> GetAll()
		{
			return DbSet.ToList();
		}

		public void Add(T entity)
		{
			DbSet.Add(entity);
		}

		public void AddRange(IEnumerable<T> entities)
		{
			DbSet.AddRange(entities);
		}

		public void Update(T entity)
		{
			DbSet.Attach(entity);
			DbSet.Entry(entity).State = EntityState.Modified;
		}

		public void Remove(T entity)
		{
			DbSet.Remove(entity);
		}
	}
}
