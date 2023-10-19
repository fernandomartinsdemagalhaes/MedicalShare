using MS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Core.PortsOut
{
    public interface IPatientRepository
    {
        string AddPatient (Patient patient);

    }
}
