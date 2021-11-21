using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Entities.Integration;
using System.Threading.Tasks;

namespace integration_sample_application
{
    public class IntegrationApplication : IIntegrationApplication
    {
        private readonly IIntegrationDomainService integrationDomainService;
        public IntegrationApplication(IIntegrationDomainService _integrationDomainService)
        {
            this.integrationDomainService = _integrationDomainService;
        }

        public async Task<bool> IntegrationCompanyBToCompanyA(IntegrationRequest integrationRequest)
        {
            return await this.integrationDomainService.IntegrationCompanyBToCompanyA(integrationRequest);
        }
    }
}