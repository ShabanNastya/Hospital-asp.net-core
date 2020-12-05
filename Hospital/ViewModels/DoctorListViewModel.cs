using System.Collections;
using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.ViewModels
{
    public class DoctorListViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public string CurrentCategory { get; set; }
    }
}