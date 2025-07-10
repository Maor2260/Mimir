using Repository;
using Service.MatchService;
using Service.PlayerService;
using Service.QuestionService;

namespace Server;

public static class ServiceExtensionMethods
{
    public static void SetupDataContext(this IServiceCollection service)
    {
        service.AddDbContext<DataContext>();
    }

    public static void SetupDependencyInjections(this IServiceCollection service)
    {
        service.AddScoped<IDataContext, DataContext>();
        service.AddScoped<IQuestionRepository, QuestionRepository>();
        service.AddScoped<IMatchRepository, MatchRepository>();
        service.AddScoped<IPlayerRepository, PlayerRepository>();
        
        service.AddScoped<IQuestionService, QuestionService>();
        service.AddScoped<IMatchService, MatchService>();
        service.AddScoped<IPlayerService, PlayerService>();
    }

    public static void SetupSwagger(this IServiceCollection service)
    {
        service.AddEndpointsApiExplorer();
        service.AddSwaggerGen();
    }

    public static void SetupCors(this IServiceCollection service)
    {
        service.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
            {
                //policy.WithOrigins(Environment.GetEnvironmentVariable("applicationUrl") ?? "http://localhost:5143")
                //policy.AllowAnyOrigin()
                policy.WithOrigins("http://localhost:5026")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });
    }
}