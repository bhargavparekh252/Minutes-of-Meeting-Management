using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult DepartmentList()
        {
            return View();
        }
        public IActionResult DepartamentAddEdit()
        {
            return View();
        }
    }
}
