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
    public class CompanyBController : ControllerBase
    {
        private readonly ICompanyBApplication companyBApplication;
        public CompanyBController(ICompanyBApplication _companyBApplication)
        {
            this.companyBApplication = _companyBApplication;
        }

        [Route("get-invoice-companyb")]
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            try
            {
                var result = await this.companyBApplication.GetInvoiceById(id);

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