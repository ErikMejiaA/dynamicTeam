
namespace WebApi.Extensions;

public static class ApplicationsServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin() //WithOrigins("https://domini.com")
                    .AllowAnyMethod()       //WithMethods(*GET ", "POST")
                    .AllowAnyHeader()      //WithHeaders(*accept*, "content-type")
                );


        }
    ); 
        
}
