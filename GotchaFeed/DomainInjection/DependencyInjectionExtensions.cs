using Domain.BaseMongo.Repository;
using Domain.BaseMongo.Settings;
using Domain.Post.Repository;
using Domain.Post.Repost.Repository;
using Domain.Post.Repost.Service;
using Domain.Post.Service;
using Domain.Users.Repository;
using Domain.Users.Service;
using Infraestructure.Context;
using Infraestructure.Repository.BaseMongo;
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
            ConfigurePost(services);
            ConfigureRepost(services);

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

        public static void ConfigurePost(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPostService, PostService>();
        }

        public static void ConfigureRepost(this IServiceCollection services)
        {
            services.AddScoped<IRepostRepository, RepostRepository>();
            services.AddScoped<IRepostService, RepostService>();
        }
    }
}
