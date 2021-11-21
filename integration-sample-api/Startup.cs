using integration_sample_cross_cutting;
using integration_sample_infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace integration_sample_api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            CompanyBServiceContext.urlApi = Configuration.GetSection("UrlCompanyBApi").Value;
            CompanyBServiceContext.userApi = Configuration.GetSection("UserCompanyBApi").Value;
            CompanyBServiceContext.passwordApi = Configuration.GetSection("PasswordCompanyBApi").Value;

            CompanyAServiceContext.urlApi = Configuration.GetSection("UrlCompanyAApi").Value;
            CompanyAServiceContext.userApi = Configuration.GetSection("UserCompanyAApi").Value;
            CompanyAServiceContext.passwordApi = Configuration.GetSection("PasswordCompanyAApi").Value;
            CompanyAServiceContext.companyApi = Configuration.GetSection("CompanyCompanyAApi").Value;
            CompanyAServiceContext.lineApi = Configuration.GetSection("LineCompanyAApi").Value;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            DependencyInjection.GetDependencyInjection(services);
            AuthenticationAutorizationService.GetAuthenticationAutorizationService(services);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "integration_sample_api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "integration_sample_api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
