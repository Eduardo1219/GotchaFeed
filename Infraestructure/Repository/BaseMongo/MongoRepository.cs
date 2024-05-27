using Domain.BaseMongo.Entity;
using Domain.BaseMongo.Repository;
using Domain.BaseMongo.Settings;
using Domain.Feed.Entity;
using Domain.Gotcha.Repository;
using Domain.MockData.Feed;
using MongoDB.Driver;
using SharpCompress.Common;
using System.Linq.Expressions;

namespace Infraestructure.Repository.BaseMongo
{
    public class MongoRepository<T> : IMongoRepository<T> where T : BaseMongoEntity
    {

        private readonly IMongoCollection<T> _model;
        
        public MongoRepository(IDatabaseSettings settings, IGotchaRepository databaseGotcha)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _model = database.GetCollection<T>(typeof(T).Name.ToLower());
            var register = _model.Find<T>(g => true).FirstOrDefault();
            if (register == null) 
            {
                var feed = FeedMock.GetFeedMock<T>(databaseGotcha);
                _model.InsertOne(feed.Result);
            }

        }

        public virtual async Task AddAsync(T entity)
        {
            await _model.InsertOneAsync(entity);
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _model.Find<T>(m => m.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<T> GetFirstAsync()
        {
            return await _model.Find<T>(g => true).FirstOrDefaultAsync();
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
