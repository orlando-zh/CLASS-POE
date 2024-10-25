using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Patients
{
    public interface IPatientService
    {
        DataTable GetAllPatients();

        DataTable GetDoctors();

        void AddPatient(Patient patient);

        void EditPatient(Patient patient);

        void DeletePatient(int id);
    }
}
