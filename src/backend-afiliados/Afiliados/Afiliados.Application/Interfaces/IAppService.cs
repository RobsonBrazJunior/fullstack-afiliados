﻿namespace Afiliados.Application.Interfaces
{
	public interface IAppService<T> where T : class
	{
		T Get(Guid id);
		void Add(T obj);
		void Update(T obj);
		void Remove(T obj);
	}
}
