﻿using Domain.Gotcha.Entity;
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
    }
}