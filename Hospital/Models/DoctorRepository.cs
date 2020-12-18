using System.Collections.Generic;
using System.Linq;
using Hospital.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class DoctorRepository :IDoctorRepository
    {
        private List<Doctor> _doctorList;

        public DoctorRepository()
        {
            _doctorList = new List<Doctor>()
            {
                new Doctor() { DoctorId = 1, Name = "Мария", Category = Categ.Dentist, Email = "mary@pragtech.com" },
                new Doctor() { DoctorId = 2, Name = "Джон", Category = Categ.Therapist, Email = "john@pragtech.com" },
                new Doctor() { DoctorId = 3, Name = "Анна", Category = Categ.Therapist, Email = "annana@pragtech.com" },
                new Doctor() { DoctorId = 4, Name = "Пётр", Category = Categ.Pediatrician, Email = "petia@pragtech.com" },
            };
        }

        public Doctor Add(Doctor doctor)
        {
            doctor.DoctorId = _doctorList.Max(e => e.DoctorId) + 1;
            _doctorList.Add(doctor);
            return doctor;
        }
        
        
        public IEnumerable<Doctor> GetAllDoctor()
        {
            return _doctorList;
        }

        public Doctor GetDoctorById(int doctorId)
        {
            return this._doctorList.FirstOrDefault(e => e.DoctorId == doctorId);
            //return _appDbContext.Doctors.FirstOrDefault(c => c.DoctorId == doctorId);
        }
    }
}