using integration_sample_domains.Entities.Integration;
using System.Threading.Tasks;

namespace integration_sample_domains.Contracts.Application
{
    public interface IIntegrationApplication
    {
        Task<bool> IntegrationCompanyBToCompanyA(IntegrationRequest integrationRequest);
    }
}