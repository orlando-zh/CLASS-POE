using DataAccessLayer.Repositories.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Patients
{
    public class PatientService
    {
        private PatientRepository _patientRepository;

        public PatientService()
        {
            _patientRepository = new PatientRepository();
        }
    }
}
