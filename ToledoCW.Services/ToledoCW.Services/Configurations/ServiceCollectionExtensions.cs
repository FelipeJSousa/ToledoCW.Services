using Microsoft.EntityFrameworkCore;
using ToledoCW.Services.Application.Interfaces;
using ToledoCW.Services.Application.Services;
using ToledoCW.Services.Infraestructure;
using ToledoCW.Services.Infraestructure.Repositorios;

namespace ToledoCW.Services.Configurations;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        
        services.AddCors(options =>
        {
            options.AddPolicy("Padrao",
                x => x
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );
        });
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddDbContext<ToledoCWContext>(options =>
        {
            options.UseMySQL(configuration.GetConnectionString("Mysql"));
        });


        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<IEstabelecimentoService, EstabelecimentoService>();

        services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));

        services.AddAutoMapper(typeof(Program).Assembly);

        return services;
    }
}