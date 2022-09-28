using GreetingsWorld.Data;
using GreetingsWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GreetingsWorld.Controllers
{
    public class FacilityController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FacilityController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<FacilityPatient> objClassList = _db.Facility_Patient.ToList();
            return View(objClassList);
            
        }

        [HttpGet]
        public IActionResult UpdatePage()
        {
            List<FacilityPatient> objClassList = _db.Facility_Patient.ToList();
            return View(objClassList);
        }

        public IActionResult Edit(int facilityId, int PatientId)
        {
            FacilityPatient facilityQuery =
                (from FacilityPatient in _db.Facility_Patient
                 where FacilityPatient.PatientId == PatientId
                 select FacilityPatient).FirstOrDefault();

                facilityQuery.facilityId = facilityId;

                _db.SaveChanges();
                _db.ChangeTracker.Clear();
                return RedirectToAction("Index");
        }
    }
}
