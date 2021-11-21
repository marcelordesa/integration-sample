using integration_sample_domains.Contracts.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace integration_sample_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyAController : ControllerBase
    {
        private readonly ICompanyAApplication companyAApplication;
        public CompanyAController(ICompanyAApplication _companyAApplication)
        {
            this.companyAApplication = _companyAApplication;
        }

        [Route("get-document-account")]
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetDocumentAccount(string TipoDoc, string Serie, string Numdoc, string Filial, string Numvias, string NomeReport, string SegundaVia, string NomePDF, string EntidadeFacturacao)
        {
            try
            {
                var result = await this.companyAApplication.GetDocumentAccount(TipoDoc, Serie, Numdoc, Filial, Numvias, NomeReport, SegundaVia, NomePDF, EntidadeFacturacao);

                if (result == null)
                    return NoContent();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}