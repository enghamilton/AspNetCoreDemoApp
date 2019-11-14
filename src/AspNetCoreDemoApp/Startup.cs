using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreDemoApp
{
    public class Startup
    {
        public IConfigurationRoot Configuration {  
            get;  
            set;  
        }  
        public static string ConnectionString {  
            get;  
            private set;  
        }  
        public Startup(IHostingEnvironment env) {  
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("app.json").Build();  
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddHttpsRedirection(options => { options.HttpsPort = 443; })
                .AddMvcCore()
                .AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy",
                        builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
                });

            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = ForwardedHeaders.XForwardedFor |
                                           ForwardedHeaders.XForwardedProto;
                options.KnownNetworks.Clear();
                options.KnownProxies.Clear();
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseForwardedHeaders();

            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DYNO")))
            {
                Console.WriteLine("Use https redirection");
                app.UseHttpsRedirection();
            }

            app
                .UseRouting()
                .UseDefaultFiles()
                .UseStaticFiles()
                .UseCors("CorsPolicy")
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapDefaultControllerRoute();
                });
            
            ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
