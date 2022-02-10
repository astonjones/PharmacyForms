using System.ComponentModel.DataAnnotations;

namespace PharmacyForms.Models
{
    public class PatientCountModel
    {
        [Key]
        public string Id { get; set; }
        public DateTime EntryDate {  get; set; }
        public DateTime ModifyDate { get; set; }
        public string PharmacyName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string TimeOfDay { get; set; }
        public int PatientCount { get; set; }
    }
}
