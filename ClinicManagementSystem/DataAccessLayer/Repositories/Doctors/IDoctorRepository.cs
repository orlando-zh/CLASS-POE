using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Doctors
{
    public interface IDoctorRepository
    {
        DataTable GetAllDoctor();

        void AddDoctor(Doctor doctor);

        void UpdateDoctor(Doctor doctor);

        void DeleteDoctor(int id);
    }
}
