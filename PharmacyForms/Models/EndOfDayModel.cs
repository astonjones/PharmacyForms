using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PharmacyForms.Models
{
    public class EndOfDayModel
    {
        [Key]
        public string ?Id {  get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string Name {  get; set; }
        public string PharmacyName {  get; set; }
        public string GroupName { get; set; }

        [Display(Name = "Patient Count - Number of Approved Patients")]
        public double ApprovedPatientCount { get; set; }

        [Display(Name = "Patient Count - Number of Denied Patients")]
        public double DeniedPatientCount { get; set; }

        [Display(Name = "RXs Count - Total Paid Prescriptions")]
        public double RxCount { get; set; }

        [Display(Name = "No of High Copays (Patients)")]
        public double HighCopayCount { get; set; }

        [Display(Name = "Insurance Errors (Patients)")]
        public double InsuranceErrors { get; set; }

        [Display(Name = "Wrong DOB (Patients)")]
        public double WrongDOBCount { get; set; }

        [Display(Name = "Exceptions - Pharmacy Not Contracted (Patients)")]
        public double NotContractedCount { get; set; }

        [Display(Name = "Exceptions - Wrong Last Name (Patients)")]
        public double WrongLastNameCount { get; set; }

        [Display(Name = "Exceptions - Patients Insurance Terminated (Patients)")]
        public double InsuranceTerminatedCount { get; set; }

        [Display(Name = "Exceptions - Other - Please Specify")]
        public string OtherExceptions { get; set; }

        [Display(Name = "Total No. of Exception Patients for")]
        public double PatientExceptionCount { get; set; }

        [Display(Name = "Total No. of Existing Patients")]
        public double TotalExistingPatients { get; set; }

        [Display(Name = "Total No. of Transferrd-In Patients (from sister pharmacies")]
        public double TransferredPatientCount { get; set; }

        [Display(Name = "Adjudication - (Total Amount of Insurance Paid")]
        public decimal InsuranceAdjudications { get; set; }

        [Display(Name = "Cost of Goods Sold - (Acquisition Cost A.A.C")]
        public double Cogs { get; set; }

        [Display(Name = "Refill - Total RXs")]
        public double RxRefills { get; set; }

        [Display(Name = "Refill - Adjudications")]
        public double RefillAdjudications { get; set; }

        [Display(Name = "Alternative Cost of Goods")]
        public double RefillCogs { get; set; }

        [Display(Name = "Refill Alternative Adjudications")]
        public double AlternativeAdjudications { get; set; } // - NOT SURE IF THIS IS REDUNDANT OR NOT - SEE Refill Adjudications

        [Display(Name = "Refill - Alternative Cost of Goods")]
        public double AlternativeCogs { get; set; } // -- NOT SURE IF THIS IS REDUNDANT OR NOT - SEE Refill Cogs

        [Display(Name = "Internal Transfers")]
        public double InternalTransfer {  get; set; }

        [Display(Name = "Existing Patients")]
        public double ExistingPatients {  get; set; }
    }
}
