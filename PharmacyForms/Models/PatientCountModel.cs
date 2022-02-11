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
        public string Name { get; set; }
        [Display(Name = "Time Of Day")]
        public string TimeOfDay { get; set; }
        [Display(Name = "Patient Count")]
        public int PatientCount { get; set; }
    }
}
