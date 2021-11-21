using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Contracts.Infra;
using integration_sample_domains.Entities.CompanyB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace integration_sample_domain_services
{
    public class CompanyBDomainService : ICompanyBDomainService
    {
        private readonly ICompanyBServiceContext companyBServiceContext;
        public CompanyBDomainService(ICompanyBServiceContext _companyBServiceContext)
        {
            this.companyBServiceContext = _companyBServiceContext;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            return await this.companyBServiceContext.GetAllInvoices();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await this.companyBServiceContext.GetInvoiceById(id);
        }

        public async Task<bool> PostInvoices(Invoice invoice)
        {
            return await this.companyBServiceContext.PostInvoices(invoice);
        }
    }
}