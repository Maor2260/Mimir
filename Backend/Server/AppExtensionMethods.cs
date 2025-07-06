namespace Server;

public static class AppExtensionMethods
{
    public static void SetupSwagger(this WebApplication application)
    {
        application.UseSwagger();
        application.UseSwaggerUI(SetupSwagger());
    }

    public static void SetupCors(this WebApplication application)
    {
        application.UseCors();
        //application.MapHub<GameHub>("/gamehub");
    }
    
    private static Action<Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIOptions> SetupSwagger()
    {
        return options =>
        {
            options.DefaultModelsExpandDepth(-1); // Disable the "Schemas" collapsable list of classes at the bottom of the page.
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Mimir's API");
            options.RoutePrefix = "mimir/v1";
        };
    }
}