using Domain.Post.Repost.Entity;
using Domain.Post.Repost.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Repost.Service
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
