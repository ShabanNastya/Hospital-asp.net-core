using System.Collections.Generic;
using System.Linq;
using Hospital.Interfaces;

namespace Hospital.Models
{
    public class DoctorRepository :IDoctorRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        
        public IEnumerable<Doctor> GetAllDoctor => new List<Doctor>
        {
            new Doctor
            {
                DoctorId = 1, Surname = "Зюзя",Name = "Анна", MiddleName = "Иванович", Description = "00001",
                Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl = "https://stihi.ru/pics/2019/07/02/5109.jpg",
                ImageThumbnailUrl = "https://www.cossa.ru/upload/main/75c/2084029b4bb02c68fec73586b613b8ec_16.jpg"
            },
            new Doctor
            {
            DoctorId = 2, Surname = "Качан",Name = "Катя", MiddleName = "Владимировна", Description = "000002",
            Category = _categoryRepository.GetAllCategories.ToList()[1],
            ImageUrl = "https://img2.freepng.ru/20180614/fxg/kisspng-hospital-nursing-care-health-care-clinic-medicine-woman-doctor-5b224e6ec82644.4139836515289749588198.jpg",
            ImageThumbnailUrl = "https://www.cossa.ru/upload/main/75c/2084029b4bb02c68fec73586b613b8ec_16.jpg"
            },
            new Doctor
            {
                DoctorId = 3, Surname = "Петров",Name = "Иван", MiddleName = "Петрович", Description = "000003",
                Category = _categoryRepository.GetAllCategories.ToList()[2],
                ImageUrl = "http://www.hair-transplant-pune.com/wp-content/uploads/2016/01/doctor.jpg",
                ImageThumbnailUrl = "https://qph.fs.quoracdn.net/main-thumb-365182016-100-ryuxicbgcfvnzgjvzaiharnosozzrvdg.jpeg"
            }
        };
        
        
        public Doctor GetDoctorById(int doctorId)
        {
            return GetAllDoctor.FirstOrDefault(c => c.DoctorId == doctorId);
        }
    }
}