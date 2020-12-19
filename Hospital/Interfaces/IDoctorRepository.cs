using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctor();
        Doctor GetDoctorById(int doctorId);

        Doctor Add(Doctor doctor);

    }
}