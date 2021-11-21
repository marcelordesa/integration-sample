using integration_sample_domains.Entities.CompanyB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace integration_sample_domains.Contracts.Infra
{
    public interface ICompanyBServiceContext
    {
        Task<List<Invoice>> GetAllInvoices();
        Task<Invoice> GetInvoiceById(int id);
        Task<bool> PostInvoices(Invoice invoice);
    }
}