using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace andaniStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult StudentGroup()
        {
            List<Models.StudyGroup> students = new List<Models.StudyGroup>();
            students.Add(new Models.StudyGroup { StudentNo = "u12345678", FirstName = "Jane", LastName = "Doe", EmailAddress = "jane.doe@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNo = "u01234567", FirstName = "John", LastName = "Doe", EmailAddress = "john.doe@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNo = "u23957281", FirstName = "Andani", LastName = "Bologo", EmailAddress = "u23957281@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNo = "u23619270", FirstName = "Vhuthuhawe", LastName = "Negondeni", EmailAddress = "u23619270@tuks.co.za" });
            students.Add(new Models.StudyGroup { StudentNo = "u23854830", FirstName = "Dakalo", LastName = "Nemamilwe", EmailAddress = "u23854830@tuks.co.za" });
            

            return View(students);
        }
    }
}