using integration_sample_domains.Entities.Integration;
using System.Threading.Tasks;

namespace integration_sample_domains.Contracts.DomainServices
{
    public interface IIntegrationDomainService
    {
        Task<bool> IntegrationCompanyBToCompanyA(IntegrationRequest integrationRequest);
    }
}