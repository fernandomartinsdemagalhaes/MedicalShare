using Microsoft.AspNetCore.Mvc;
using MS.Core.Domain.Entities;
using MS.Core.PortsIn;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MS.ApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientContoller : ControllerBase
    {
         private readonly IPatientService patientService;

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
        public void Post([FromBody] string value)
        {
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
