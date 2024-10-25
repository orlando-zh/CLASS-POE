using CommonLayer.Entities;
using DataAccessLayer.Repositories.Doctors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Doctors
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public void AddDoctor(Doctor doctor)
        {
           _doctorRepository.AddDoctor(doctor);
        }

        public void DeleteDoctor(int id)
        {
            _doctorRepository.DeleteDoctor(id);
        }

        public void EditDoctor(Doctor doctor)
        {
            _doctorRepository.UpdateDoctor(doctor);
        }

        public DataTable GetAllDoctors()
        {
            return _doctorRepository.GetAllDoctor();
        }
    }
}
