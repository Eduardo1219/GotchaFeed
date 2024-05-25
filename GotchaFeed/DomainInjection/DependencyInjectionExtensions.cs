using Domain.BaseMongo.Repository;
using Domain.BaseMongo.Settings;
using Domain.Feed.Repository;
using Domain.Feed.Service;
using Domain.Gotcha.Repository;
using Domain.Gotcha.Repost.Repository;
using Domain.Gotcha.Repost.Service;
using Domain.Gotcha.Service;
using Domain.Users.Repository;
using Domain.Users.Service;
using Infraestructure.Context;
using Infraestructure.Repository.BaseMongo;
using Infraestructure.Repository.FeedRepository;
using Infraestructure.Repository.PostRepository;
using Infraestructure.Repository.RepostRepository;
using Infraestructure.Repository.UsersRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace GotchaFeed.DomainInjection
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureContext(services, configuration);
            ConfigureMongo(services, configuration);
            ConfigureUsers(services);
            ConfigureGotcha(services);
            ConfigureRepost(services);
            ConfigureFeed(services);

            return services;
        }

        public static void ConfigureContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GotchaFeedContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));
        }

        public static void ConfigureMongo(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseSettings>(configuration.GetSection(nameof(DatabaseSettings)));
            services.AddSingleton<IDatabaseSettings>(m => m.GetRequiredService<IOptions<DatabaseSettings>>().Value);

            services.AddSingleton(typeof(IMongoRepository<>), typeof(MongoRepository<>));
        }

        public static void ConfigureUsers(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUsersService, UsersService>();
        }

        public static void ConfigureGotcha(this IServiceCollection services)
        {
            services.AddScoped<IGotchaRepository, GotchaRepository>();
            services.AddScoped<IGotchaService, GotchaService>();
        }

        public static void ConfigureRepost(this IServiceCollection services)
        {
            services.AddScoped<IRepostRepository, RepostRepository>();
            services.AddScoped<IRepostService, RepostService>();
        }

        public static void ConfigureFeed(this IServiceCollection services)
        {
            services.AddScoped<IFeedRepository, FeedRepository>();
            services.AddScoped<IFeedService, FeedService>();
        }
    }
}
