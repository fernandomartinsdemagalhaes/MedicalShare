using Microsoft.AspNetCore.Mvc;
using MS.Core.Domain.Entities;
using MS.Core.PortsIn;
using MS.Core.PortsIn.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MS.ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientContoller : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientContoller(IPatientService patientService)
        {
            _patientService = new PatientService();
        }           
            
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            
            return new List<Patient>();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            _patientService.CreatetePatient(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
