namespace Hospital.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        
        public string Surname { get; set; }
        
        public string Name { get; set; }
        
        public string MiddleName { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        
        public string ImageThumbnailUrl { get; set; }
        
        public string Email { get; set; }
        
        //Нужно добавить дату работы
        //Либо как 2 цифры
        //Либо как тип дата
        
        public int CategoryId { get; set; }
        
        public Categ Category { get; set; }
    }
}