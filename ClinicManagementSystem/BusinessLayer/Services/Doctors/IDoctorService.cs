using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Doctors
{
    public interface IDoctorService
    {
        DataTable GetAllDoctors();

        void AddDoctor(Doctor doctor);

        void EditDoctor(Doctor doctor);

        void DeleteDoctor(int id);
    }
}
