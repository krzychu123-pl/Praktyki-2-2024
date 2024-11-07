﻿using System.Linq.Expressions;
namespace Tutorial.Models
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllByIdAsync<TKey>(TKey id, string propertyname, QueryOptions<T> options);

        Task<T> GetByIdAsync(int  id, QueryOptions<T> options);
        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int id);

    }
}