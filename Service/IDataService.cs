using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppGenealogySystem.Service
{
    public interface IDataService
    {
        IQueryable<T> GetData<T>() where T : class;
        void WarmUp();
        Task<List<TResult>> GetDataAsync<T, TResult>(
        Expression<Func<T, bool>> filter,
        Expression<Func<T, TResult>> selector)
        where T : class;
        int GetCount<T>() where T : class;
        Task<int> GetCountAsync<T>() where T : class;
        Task<int> GetCountFilterAsync<T>(Expression<Func<T, bool>> filter) where T : class;

        Task<List<TResult>> GetDataLimitAsync<T, TResult>(
       Expression<Func<T, bool>> filter,
       Expression<Func<T, TResult>> selector, int offset, int limit)
       where T : class;

        // Thêm mới bất kỳ Model nào
        void Add<T>(T entity) where T : class;

        // Tìm kiếm với điều kiện (LinQ)
        List<T> Find<T>(Expression<Func<T, bool>> predicate) where T : class;
        T? FindOne<T>(Expression<Func<T, bool>> predicate) where T : class;
        List<TResult> GetProductLimit<T, TResult>(
       Expression<Func<T, bool>> filter,
       Expression<Func<T, TResult>> selector, int offset, int limit)
       where T : class;
        void Update<T>(T entity) where T : class;
        Task DeleteAsync<T>(long id) where T : class;
        void Fake(int count);
    }
}
