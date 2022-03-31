using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmacyForms.Data;
using PharmacyForms.Models;

namespace PharmacyForms.Controllers
{
    [Authorize]
    public class PharmFormController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PharmFormController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<PatientCountModel> PatientCountRecords = _db.PatientCounts.Where(i => i.EntryDate >= DateTime.Now.Date && i.Email == User.Identity.Name);
            IEnumerable<EndOfDayModel> EndOfDayRecords = _db.EndOfDay.Where(i => i.EntryDate >= DateTime.Now.Date && i.Email == User.Identity.Name);
            ListHolderModel listHolder = new ListHolderModel(PatientCountRecords, EndOfDayRecords);
            return View(listHolder);
        }

        public IActionResult yesterdayRecords()
        {
            IEnumerable<PatientCountModel> yesterdayPatientRecords = _db.PatientCounts.Where(i => i.EntryDate >= DateTime.Today.AddDays(-1) && i.EntryDate <= DateTime.Today && i.Email == User.Identity.Name);
            IEnumerable<EndOfDayModel> yesterdayEndOfDayRecords = _db.EndOfDay.Where(i => i.EntryDate >= DateTime.Today.AddDays(-1) && i.EntryDate <= DateTime.Today && i.Email == User.Identity.Name);
            ListHolderModel listHolder = new ListHolderModel(yesterdayPatientRecords, yesterdayEndOfDayRecords);
            return View(listHolder);
        }

        //GET
        public IActionResult PatientCountCreate()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PatientCountCreate(PatientCountModel obj)
        {
            var dateId = DateTime.Now.ToString("dd-MM-yyyy"); //Used for the record IDs
            string PharmacyName = obj.PharmacyName.Replace(" ", "");
            //Checks if Start of Day, Throughout day, and End of Day record exists if so then redirect to details
            if (obj.TimeOfDay == "SOD")
            {
                dateId += $"SOD{PharmacyName}";
                if (_db.PatientCounts.Any(i => i.Id == dateId)) { return RedirectToAction("PatientCountDetails", new { id = dateId }); }
                obj.Id = dateId; //If record does not exist populate Id
            }
            else if (obj.TimeOfDay == "EOD")
            {
                dateId += $"EOD{PharmacyName}";
                if (_db.PatientCounts.Any(i => i.Id == dateId)) { return RedirectToAction("PatientCountDetails", new { id = dateId }); }
                obj.Id = dateId; //If record does not exist populate Id
            }
            else if (obj.TimeOfDay == "TD")
            {
                dateId += $"TD{PharmacyName}";
                if (_db.PatientCounts.Any(i => i.Id == dateId)) { return RedirectToAction("PatientCountDetails", new { id = dateId }); }
                obj.Id = dateId; //If record does not exist populate Id
            }
            else { return RedirectToAction("Index"); }

            obj.EntryDate = DateTime.Now;
            obj.ModifyDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _db.PatientCounts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        //GET - EDIT
        public IActionResult PatientCountEdit(string id)
        {
            if (id == null)
                return NotFound();

            var obj = _db.PatientCounts.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PatientCountEdit(PatientCountModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.ModifyDate = DateTime.Now;
                _db.PatientCounts.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get - Details
        public IActionResult PatientCountDetails(string id)
        {
            if (id == null)
                return NotFound();

            var obj = _db.PatientCounts.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        //------------- END OF DAY RECORDS ---------------------

        //GET
        public IActionResult EndOfDayCreate()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EndOfDayCreate(EndOfDayModel obj)
        {
            var dateId = DateTime.Now.ToString("dd-MM-yyyy"); //Used for the record IDs
            string PharmacyName = obj.PharmacyName.Replace(" ", ""); //Get rid of spaces between pharmacies name
            dateId = $"{dateId}{PharmacyName}";
            //Checks if Start of Day record exists
            if (_db.EndOfDay.Any(i => i.Id == dateId)) {
                return RedirectToAction("EndOfDayDetails", new { id = dateId });
            }

            obj.Id = dateId;
            obj.EntryDate = DateTime.Now;
            obj.ModifyDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _db.EndOfDay.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        //GET - EDIT
        public IActionResult EndOfDayEdit(string id)
        {
            if (id == null)
                return NotFound();

            var obj = _db.EndOfDay.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EndOfDayEdit(EndOfDayModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.ModifyDate = DateTime.Now;
                _db.EndOfDay.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //Get - Details
        public IActionResult EndOfDayDetails(string id)
        {
            if (id == null)
                return NotFound();

            var obj = _db.EndOfDay.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }
    }
}
