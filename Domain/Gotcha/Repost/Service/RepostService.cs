using Domain.Gotcha.Repost.Entity;
using Domain.Gotcha.Repost.Repository;

namespace Domain.Gotcha.Repost.Service
{
    public class RepostService : IRepostService
    {
        private readonly IRepostRepository _repository;

        public RepostService(IRepostRepository repository)
        {
            _repository = repository;
        }


        public async Task AddAsync(RepostEntity entity)
        {
            await _repository.AddAsync(entity);
        }
    }
}
