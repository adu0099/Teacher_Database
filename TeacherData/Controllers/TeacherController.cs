using Microsoft.AspNetCore.Mvc;
using TeacherData.DAL;
using TeacherData.Models;
using TeacherData.Models.DBEntities;

namespace TeacherData.Controllers
{
    public class TeacherController : Controller
    {
        private readonly TeacherDbContext _context;

        public TeacherController(TeacherDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var teachers = _context.Teachers.ToList();
            List<TeacherViewModel> teacherlist = new List<TeacherViewModel>();

            if (teachers != null)
            {
                foreach(var teacher in teachers)
                {
                    var TeacherViewModel = new TeacherViewModel()
                    {
                        Id = teacher.Id,
                        FirstName = teacher.FirstName,
                        LastName = teacher.LastName,
                        Department = teacher.Department,
                        JoinDate = teacher.JoinDate,
                        Email = teacher.Email,
                        Phone = teacher.Phone
                    };
                 teacherlist.Add(TeacherViewModel);
                }
             return View(teacherlist);
            }
         return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(TeacherViewModel teacherdata)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var teacher = new Teacher()
                    {
                        FirstName = teacherdata.FirstName,
                        LastName = teacherdata.LastName,
                        Department = teacherdata.Department,
                        JoinDate = teacherdata.JoinDate,
                        Email = teacherdata.Email,
                        Phone = teacherdata.Phone
                    };
                    _context.Teachers.Add(teacher);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Teacher Created successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not Valid ";
                    return View();

                }
            }
            catch (Exception ex)
            {
                TempData["errroeMessage"] = ex.Message;
                return View();

               
            }
            
        }

    }
}
