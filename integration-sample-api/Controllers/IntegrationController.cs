using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Entities.Integration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace integration_sample_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        private readonly IIntegrationApplication integrationApplication;
        public IntegrationController(IIntegrationApplication _integrationApplication)
        {
            this.integrationApplication = _integrationApplication;
        }

        [Route("post-integration-campanyb-to-companya")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostIntegrationCompanyBToCompanyA([FromBody]IntegrationRequest integrationRequest)
        {
            try
            {
                var result = await this.integrationApplication.IntegrationCompanyBToCompanyA(integrationRequest);

                if (result == false)
                    return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao integrar a nota fiscal do company B para o company A");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}