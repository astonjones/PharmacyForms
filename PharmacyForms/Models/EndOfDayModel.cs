using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PharmacyForms.Models
{
    public class EndOfDayModel
    {
        [Key]
        public double Id {  get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Email { get; set; }
        public string Name {  get; set; }
        public string GroupName { get; set; }
        public double ApprovedPatientCount { get; set; }
        public double DeniedPatientCount { get; set; }
        public double RxCount { get; set; }
        public double HighCopayCount { get; set; }
        public double InsuranceErrors { get; set; }
        public double WrongDOBCount { get; set; }
        public double NotContractedCount { get; set; }
        public double WrongLastNameCount { get; set; }
        public double InsuranceTerminatedCount { get; set; }
        public string OtherExceptions { get; set; }
        public decimal InsuranceAdjudications { get; set; }
        public double Cogs { get; set; }
        public double RxRefills { get; set; }
        public double RefillAdjudications { get; set; }
        public double RefillCogs { get; set; }
        public double AlternativeAdjudications { get; set; }
        public double AlternativeCogs { get; set; }
        public double PatientExceptionCount { get; set; }
        public double ExistingPatientCount { get; set; }
        public double TransferredPatientCount { get; set; }
    }
}
