using Domain.Gotcha.Entity;

namespace Domain.Gotcha.Service
{
    public interface IGotchaService
    {
        Task AddAsync(GotchaEntity entity);
    }
}
