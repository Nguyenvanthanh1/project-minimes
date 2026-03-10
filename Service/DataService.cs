using AppGenealogySystem.Context;
using AppGenealogySystem.Enums;
using AppGenealogySystem.Models;
using AppGenealogySystem.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace AppGenealogySystem.Service
{
    public class DataService : IDataService
    {
        private readonly IDbContextFactory<AppDBContext> _dbFactory;

        public DataService(IDbContextFactory<AppDBContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public IQueryable<T> GetData<T>() where T : class
        {
            var db = _dbFactory.CreateDbContext();
            return db.Set<T>();
        }
        public async void WarmUp()
        {
            using var db = _dbFactory.CreateDbContext();
            db.Products.Skip(1).ToList();
        }
        public async Task<int> GetCountAsync<T>() where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            return db.Set<T>().Count();
        }
        public int GetCount<T>() where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            return db.Set<T>().Count();
        }
        public async Task<int> GetCountFilterAsync<T>(Expression<Func<T, bool>> filter) where T : class
        {
            await using var db = _dbFactory.CreateDbContext();
            return db.Set<T>().AsNoTracking().Where(filter).Count();
        }
        public async Task<List<TResult>> GetDataAsync<T, TResult>(
            Expression<Func<T, bool>> filter,
            Expression<Func<T, TResult>> selector) where T : class
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Set<T>()
                  .AsNoTracking()
                  .Where(filter)
                  .OrderBy(x => 1)
                  .Select(selector)
                  .ToListAsync();
        }
        public async Task<List<TResult>> GetDataLimitAsync<T, TResult>(
           Expression<Func<T, bool>> filter,
           Expression<Func<T, TResult>> selector, int offset, int limit) where T : class
        {
            await using var db = _dbFactory.CreateDbContext();
            return await db.Set<T>()
                  .AsNoTracking()
                  .Where(filter)
                  .OrderBy(x => 1)
                  .Select(selector)
                  .Skip(offset)
                  .Take(limit)
                  .ToListAsync();
        }

        public List<TResult> GetProductLimit<T, TResult>(
           Expression<Func<T, bool>> filter,
           Expression<Func<T, TResult>> selector, int offset, int limit) where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            return db.Set<T>()
                  .AsNoTracking()
                  .Where(filter)
                  .OrderBy(x => 1)
                  .Select(selector)
                  .Skip(offset)
                  .Take(limit)
                  .ToList();
        }

        public virtual void Add<T>(T entity) where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public List<T> Find<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            return db.Set<T>().Where(predicate).ToList();
        }
        public T? FindOne<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            return db.Set<T>().FirstOrDefault(predicate);
        }
        public void Update<T>(T entity) where T : class
        {
            using var db = _dbFactory.CreateDbContext();
            db.Update(entity);
            db.SaveChanges();
        }

        public async Task DeleteAsync<T>(long id) where T : class
        {

            using var db = _dbFactory.CreateDbContext();
            var model = await db.Set<T>().FindAsync(id);
            if (model == null)
            {
                return;
            }
            db.Remove(model);
            await db.SaveChangesAsync();
        }
        public void Fake(int count)
        {
            using var db = _dbFactory.CreateDbContext();
            var products = FakeData.GenerateFakeProducts(count);

            foreach (var product in products)
            {
                Add(product);
            }
        }
    }
}
