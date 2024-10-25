using CommonLayer.Entities;
using DataAccessLayer.Repositories.Patients;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Patients
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public void AddPatient(Patient patient)
        {
            _patientRepository.AddPatient(patient);
        }

        public void DeletePatient(int id)
        {
            _patientRepository.DeletePatient(id);
        }

        public void EditPatient(Patient patient)
        {
            _patientRepository.EditPatient(patient);
        }

        public DataTable GetAllPatients()
        {
            return _patientRepository.GetAllPatients();
        }

        public DataTable GetDoctors()
        {
            return _patientRepository.GetDoctors();
        }
    }
}
