using System.ComponentModel.DataAnnotations;

namespace PharmacyForms.Models
{
    public class PatientCountModel
    {
        [Key]
        public string ?Id { get; set; }
        public DateTime EntryDate {  get; set; }

        [Display(Name = "Date last Modified")]
        public DateTime ModifyDate { get; set; }

        [Display(Name = "Pharmacy Name")]
        public string PharmacyName { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Time Of Day")]
        public string TimeOfDay { get; set; }

        [Display(Name = "Patient Count")]
        [Required(ErrorMessage = "Please enter patient count as a number.")]
        public int PatientCount { get; set; }
    }
}
