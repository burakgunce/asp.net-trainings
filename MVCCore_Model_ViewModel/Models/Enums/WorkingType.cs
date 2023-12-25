using System.ComponentModel.DataAnnotations;

namespace MVCCore_Model_ViewModel.Models.Enums
{
    public enum WorkingType
    {
        [Display(Name = "Tam Zamanlı")]
        FullTime = 1,
        [Display(Name = "Yarı Zamanlı")]
        PartTime,
        [Display(Name = "Proje Bazlı")]
        ProjectedBased,
        [Display(Name = "Serbest Zamanlı")]
        Freelance
    }
}
