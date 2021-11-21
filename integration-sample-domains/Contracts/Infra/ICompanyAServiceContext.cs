using integration_sample_domains.Entities.CompanyA;
using System.Threading.Tasks;

namespace integration_sample_domains.Contracts.Infra
{
    public interface ICompanyAServiceContext
    {
        Task<bool> PostDocumentAccount(DocumentAccount documentAccount);
        Task<DocumentAccount> GetDocumentAccount(string TipoDoc, string Serie, string Numdoc, string Filial, string Numvias, string NomeReport, string SegundaVia, string NomePDF, string EntidadeFacturacao);
    }
}