using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PharmacyForms.Models
{
    public class EndOfDayModel
    {
        [Key]
        public string ?Id {  get; set; }

        [Display(Name = "1. Date")]
        public DateTime EntryDate { get; set; }

        [Display(Name = "1. Date")]
        public DateTime ModifyDate { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name {  get; set; }

        [Display(Name = "2. Pharmacy Name")]
        public string PharmacyName {  get; set; }

        [Display(Name = "3. Group Name")]
        public string GroupName { get; set; }

        [Display(Name = "4. Patient Count - Number of Approved Patients")]
        public double ApprovedPatientCount { get; set; }

        [Display(Name = "5. Patient Count - Number of Denied Patients")]
        public double DeniedPatientCount { get; set; }

        [Display(Name = "6. RXs Count - Total Paid Prescriptions")]
        public double RxCount { get; set; }

        [Display(Name = "7. Exceptions - No of High Copays (Patients)")]
        public double HighCopayCount { get; set; }

        [Display(Name = "8. Exceptions - Insurance Errors (Patients)")]
        public double InsuranceErrors { get; set; }

        [Display(Name = "9. Exceptions - Wrong DOB (Patients)")]
        public double WrongDOBCount { get; set; }

        [Display(Name = "10. Exceptions - Pharmacy Not Contracted (Patients)")]
        public double NotContractedCount { get; set; }

        [Display(Name = "11. Exceptions - Wrong Last Name (Patients)")]
        public double WrongLastNameCount { get; set; }

        [Display(Name = "12. Exceptions - Patients Insurance Terminated (Patients)")]
        public double InsuranceTerminatedCount { get; set; }

        [Display(Name = "13. Exceptions - Other - Please Specify")]
        public string OtherExceptions { get; set; }

        [Display(Name = "14. Total No. of Exception Patients for")]
        public double PatientExceptionCount { get; set; }

        [Display(Name = "15. Total No. of Existing Patients")]
        public double TotalExistingPatients { get; set; }

        [Display(Name = "16. Adjudications - (Total Amount of Existing Patients")]
        public double ExistingPatientAdjudications { get; set;}

        [Display(Name = "17. Total No. of Transferred-In Patients (from sister pharmacies)")]
        public double TransferredInPatientCount { get; set; }

        [Display(Name = "18. Total No. of Transferred-Out Patients")]
        public double TransferredOutPatientCount { get; set; }

        [Display(Name = "19. Adjudications - (Total Amount of Transferred-In Patients)")]
        public double TransferredInAdjudications { get; set; }

        [Display(Name = "20. Adjudications - (Total Amount of Insurance Paid)")]
        public double InsuranceAdjudications { get; set; }

        [Display(Name = "21. Cost of Goods Sold - (Acquisition Cost A.A.C)")]
        public double Cogs { get; set; }

        [Display(Name = "22. Refill - Total RXs")]
        public double RxRefills { get; set; }

        [Display(Name = "23. Refill - Adjudications")]
        public double RefillAdjudications { get; set; }

        [Display(Name = "24. Alternative Cost of Goods")]
        public double RefillCogs { get; set; }

        [Display(Name = "25. Total No. of Alternative Refill Patients")]
        public double AlternativeRefillPatients { get; set; }

        [Display(Name = "26. Refill Alternative Adjudications")]
        public double AlternativeAdjudications { get; set; } // - NOT SURE IF THIS IS REDUNDANT OR NOT - SEE Refill Adjudications

        [Display(Name = "27. Refill - Alternative Cost of Goods")]
        public double AlternativeCogs { get; set; } // -- NOT SURE IF THIS IS REDUNDANT OR NOT - SEE Refill Cogs
    }
}
