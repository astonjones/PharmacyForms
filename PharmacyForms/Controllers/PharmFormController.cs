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
                //Checks if Start of Day record exists
            if (obj.TimeOfDay == "Start Of Day")
            {
                dateId += "SOD";
                if (_db.PatientCounts.Any(i => i.Id == dateId)) { return RedirectToAction("PatientCountDetails", new { id = dateId }); }  //NEED TO CHANGE ROUTE FOR CORRECT ERROR HANDLING
                obj.Id = dateId; //If record does not exist populate Id
            }
            else if (obj.TimeOfDay == "End Of Day")
            {
                dateId += "EOD";
                if (_db.PatientCounts.Any(i => i.Id == dateId)) { return RedirectToAction("PatientCountDetails", new { id = dateId }); }  //NEED TO CHANGE ROUTE FOR CORRECT ERROR HANDLING
                obj.Id = dateId; //If record does not exist populate Id
            }
            else { return RedirectToAction("Index"); } //NEED TO CHANGE ROUTE FOR CORRECT ERROR HANDLING

            obj.EntryDate = DateTime.Now;
            obj.ModifyDate = DateTime.Now;

            Console.WriteLine(ModelState);
            if (ModelState.IsValid)
            {
                _db.PatientCounts.Add(obj);
                _db.SaveChanges();
                Console.WriteLine("Mdae it through!");
                return RedirectToAction("Index");
            }
            Console.WriteLine("Error in create route");
            return RedirectToAction("Index"); //NEED TO CHANGE ROUTE FOR CORRECT ERROR HANDLING
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
    }
}
