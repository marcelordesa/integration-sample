using integration_sample_application;
using integration_sample_domain_services;
using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Contracts.Infra;
using integration_sample_domains.Contracts.Repositories;
using integration_sample_infra;
using integration_sample_infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace integration_sample_cross_cutting
{
    public class DependencyInjection
    {
        public static void GetDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<ICompanyBServiceContext, CompanyBServiceContext>();
            services.AddScoped<ICompanyBDomainService, CompanyBDomainService>();
            services.AddScoped<ICompanyBApplication, CompanyBApplication>();
            services.AddScoped<ICompanyAServiceContext, CompanyAServiceContext>();
            services.AddScoped<ICompanyADomainService, CompanyADomainService>();
            services.AddScoped<IIntegrationDomainService, IntegrationDomainService>();
            services.AddScoped<ICompanyAApplication, CompanyAApplication>();
            services.AddScoped<IIntegrationApplication, IntegrationApplication>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserDomainService, UserDomainService>();
            services.AddScoped<IUserApplication, UserApplication>();
        }
    }
}