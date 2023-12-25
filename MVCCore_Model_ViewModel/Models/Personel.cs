using MVCCore_Model_ViewModel.Models.Enums;

namespace MVCCore_Model_ViewModel.Models
{
    public class Personel
    {
        public int PersonelId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public DateTime BirthDate { get; set; }
        public WorkingType WorkingType { get; set; }
    }
}
