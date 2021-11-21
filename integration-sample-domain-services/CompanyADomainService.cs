using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Contracts.Infra;
using integration_sample_domains.Entities.CompanyA;
using System.Threading.Tasks;

namespace integration_sample_domain_services
{
    public class CompanyADomainService : ICompanyADomainService
    {
        private readonly ICompanyAServiceContext companyAServiceContext;
        public CompanyADomainService(ICompanyAServiceContext _companyAServiceContext)
        {
            this.companyAServiceContext = _companyAServiceContext;
        }

        public async Task<DocumentAccount> GetDocumentAccount(string TipoDoc, string Serie, string Numdoc, string Filial, string Numvias, string NomeReport, string SegundaVia, string NomePDF, string EntidadeFacturacao)
        {
            return await this.companyAServiceContext.GetDocumentAccount(TipoDoc, Serie, Numdoc, Filial, Numvias, NomeReport, SegundaVia, NomePDF, EntidadeFacturacao);
        }
    }
}