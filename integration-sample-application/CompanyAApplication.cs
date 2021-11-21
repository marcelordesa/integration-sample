using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Entities.CompanyA;
using System.Threading.Tasks;

namespace integration_sample_application
{
    public class CompanyAApplication : ICompanyAApplication
    {
        private readonly ICompanyADomainService companyADomainService;
        public CompanyAApplication(ICompanyADomainService _companyADomainService)
        {
            this.companyADomainService = _companyADomainService;
        }

        public async Task<DocumentAccount> GetDocumentAccount(string TipoDoc, string Serie, string Numdoc, string Filial, string Numvias, string NomeReport, string SegundaVia, string NomePDF, string EntidadeFacturacao)
        {
            return await this.companyADomainService.GetDocumentAccount(TipoDoc, Serie, Numdoc, Filial, Numvias, NomeReport, SegundaVia, NomePDF, EntidadeFacturacao);
        }
    }
}