using System;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using Exceptions.EntityExceptions;
using Jobly.Common;

namespace Jobly.Controllers
{
    [Route("api/[controller]"),ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet ]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _companyService.GetAll();
                return Ok(data);
            }
            catch (EntityCouldNotFoundExceptions ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new Response(4000, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new Response(4250, ex.Message));
            }
            return Ok();
        }
    }
}

