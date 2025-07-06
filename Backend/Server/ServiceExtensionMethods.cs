using Repository;
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
        
        service.AddScoped<IQuestionService, QuestionService>();
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
                policy.WithOrigins(Environment.GetEnvironmentVariable("applicationUrl") ?? "http://localhost:5143")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });
    }
}