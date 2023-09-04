namespace WebApi.Extensions;

public static class SwaggerConfig
{
    public static void AddSwagger(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSwaggerGen();
    }
}
