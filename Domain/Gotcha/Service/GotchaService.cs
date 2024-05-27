using Domain.Gotcha.Entity;
using Domain.Gotcha.Repository;

namespace Domain.Gotcha.Service
{
    public class GotchaService : IGotchaService
    {
        private readonly IGotchaRepository _repository;

        public GotchaService(IGotchaRepository repository)
        {
            _repository = repository;
        }



        public async Task AddAsync(GotchaEntity entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task AddManyAsync(List<GotchaEntity> entity)
        {
            await _repository.AddManyAsync(entity);
        }

        public async Task<GotchaEntity> GetById(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
