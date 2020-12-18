namespace Hospital.ViewModels
{
    public class DoctorEditViewModel :  DoctorCreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}