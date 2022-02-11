namespace PharmacyForms.Models
{
    public class ListHolderModel
    {
        public ListHolderModel(IEnumerable<PatientCountModel> patientCountList, IEnumerable<EndOfDayModel> endOfDayList)
        {
            this.PatientCountList = patientCountList;
            this.EndOfDayList = endOfDayList;
        }

        public IEnumerable<PatientCountModel> PatientCountList { get; set; }
        public IEnumerable<EndOfDayModel> EndOfDayList { get; set; }
    }
}
