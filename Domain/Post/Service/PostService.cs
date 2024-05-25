using Domain.Post.Entity;
using Domain.Post.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }



        public async Task AddAsync(PostEntity entity)
        {
            await _repository.AddAsync(entity);
        }
    }
}
