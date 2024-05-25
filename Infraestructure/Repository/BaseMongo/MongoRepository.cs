using Domain.BaseMongo.Entity;
using Domain.BaseMongo.Repository;
using Domain.BaseMongo.Settings;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infraestructure.Repository.BaseMongo
{
    public class MongoRepository<T> : IMongoRepository<T> where T : BaseMongoEntity
    {

        private readonly IMongoCollection<T> _model;

        public MongoRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _model = database.GetCollection<T>(typeof(T).Name.ToLower());
        }

        public virtual async Task AddAsync(T entity)
        {
            await _model.InsertOneAsync(entity);
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _model.Find<T>(m => m.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> search)
        {
            return await _model.Find<T>(search).FirstOrDefaultAsync();
        }

        public virtual async Task<List<T>> GetManyAsync(Expression<Func<T, bool>> search)
        {
            return await _model.Find<T>(search).ToListAsync();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task UpdateAsync(T entity)
        {
            await _model.ReplaceOneAsync(t => t.Id == entity.Id, entity);
        }
    }
}
