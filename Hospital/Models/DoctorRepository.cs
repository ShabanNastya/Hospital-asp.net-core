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
                new Doctor() { DoctorId = 1, Name = "Mary", Category = Categ.Dentist, Email = "mary@pragimtech.com" },
                new Doctor() { DoctorId = 2, Name = "John", Category = Categ.Therapist, Email = "john@pragimtech.com" },
                new Doctor() { DoctorId = 3, Name = "Sam", Category = Categ.Dentist, Email = "sam@pragimtech.com" },
            };
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