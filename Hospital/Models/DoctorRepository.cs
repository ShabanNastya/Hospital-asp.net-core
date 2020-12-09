using System.Collections.Generic;
using System.Linq;
using Hospital.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Models
{
    public class DoctorRepository :IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;

        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Doctor> GetAllDoctor
        {
            get
            {
                return _appDbContext.Doctors.Include(c => c.Category);
            }
        }
        
        
        public Doctor GetDoctorById(int doctorId)
        {
            return _appDbContext.Doctors.FirstOrDefault(c => c.DoctorId == doctorId);
        }
    }
}