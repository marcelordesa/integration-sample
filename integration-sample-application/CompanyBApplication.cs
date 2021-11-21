using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Entities.CompanyB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace integration_sample_application
{
    public class CompanyBApplication : ICompanyBApplication
    {
        private readonly ICompanyBDomainService companyBDomainService;
        public CompanyBApplication(ICompanyBDomainService _companyBDomainService)
        {
            this.companyBDomainService = _companyBDomainService;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            return await this.companyBDomainService.GetAllInvoices();
        }

        public async Task<Invoice> GetInvoiceById(int id)
        {
            return await this.companyBDomainService.GetInvoiceById(id);
        }

        public async Task<bool> PostInvoices(Invoice invoice)
        {
            return await this.companyBDomainService.PostInvoices(invoice);
        }
    }
}