using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CernerMpageDemo.Services;
using CernerMpageDemo.Models;

namespace CernerMpageDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IFhirService _fhirService;
        private readonly ICclService _cclService;

        public PatientsController(IFhirService fhirService, ICclService cclService)
        {
            _fhirService = fhirService;
            _cclService = cclService;
        }

        // GET /api/patients
        [HttpGet]
        public async Task<ActionResult<List<PatientModel>>> GetPatients()
        {
            var patients = await _fhirService.GetPatientsAsync();
            return Ok(patients);
        }

        // GET /api/patients/ccl
        [HttpGet("ccl")]
        public ActionResult<List<LabResult>> GetLabResults()
        {
            var results = _cclService.GetLabResults();
            return Ok(results);
        }
    }
}
