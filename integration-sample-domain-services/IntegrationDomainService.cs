using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Contracts.Infra;
using integration_sample_domains.Entities.Integration;
using integration_sample_domains.Entities.CompanyA;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace integration_sample_domain_services
{
    public class IntegrationDomainService : IIntegrationDomainService
    {
        private readonly ICompanyBServiceContext companyBServiceContext;
        private readonly ICompanyAServiceContext companyAServiceContext;
        public IntegrationDomainService(ICompanyBServiceContext _companyBServiceContext, ICompanyAServiceContext _companyAServiceContext)
        {
            this.companyBServiceContext = _companyBServiceContext;
            this.companyAServiceContext = _companyAServiceContext;
        }

        public async Task<bool> IntegrationCompanyBToCompanyA(IntegrationRequest integrationRequest)
        {
            var invoice = await this.companyBServiceContext.GetInvoiceById(integrationRequest.Id);

            var document = new DocumentAccount
            {
                Ano = DateTime.Parse(invoice.DateCreated).Year,
                BalFinanceira = true,
                DataIntegracaoCCT = 0,
                Descricao = invoice.Note,
                Diario = "",
                Documento = invoice.Number,
                EmModoEdicao = false,
                IntegraCCT = true,
                Numerador = int.Parse(invoice.Id),
                TipoLancamento = "",
                LinhasDocumento = new List<Linhasdocumento>
                {
                    new Linhasdocumento
                    {
                        Ano = DateTime.Parse(invoice.DateCreated).Year,
                        Conta = "",
                        DescricaoEntidade = invoice.Items[0].Description,
                        Documento = invoice.Items[0].Id,
                        Grupo = 0,
                        EmModoEdicao = false,
                        Natureza = "",
                        PoeValor = false,
                        Repete = false,
                        SujeitaDuodecimos = false
                    }
                }
            };

            return await this.companyAServiceContext.PostDocumentAccount(document);
        }
    }
}