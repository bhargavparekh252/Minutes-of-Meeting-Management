using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffList()
        {
            return View();
        }
        public IActionResult StaffAddEdit()
        {
            return View();
        }

    }
}
