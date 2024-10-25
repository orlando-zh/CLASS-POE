using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Patients
{
    public interface IPatientRepository
    {
        DataTable GetAllPatients();

        void AddPatient(Patient patient);

        void EditPatient(Patient patient);

        void DeletePatient(int id);

        DataTable GetDoctors();
    }
}
