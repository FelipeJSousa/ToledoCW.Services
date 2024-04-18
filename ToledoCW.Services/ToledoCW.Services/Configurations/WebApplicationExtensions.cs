namespace ToledoCW.Services.Configurations;

public static class WebApplicationExtensions
{
    public static async Task<WebApplication> UseWebApplication(this WebApplication app, IConfiguration configuration)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors("Padrao");

        app.MapControllers();
        
        app.UseHttpsRedirection();

        await app.RunAsync();
        
        return app;
    }
}