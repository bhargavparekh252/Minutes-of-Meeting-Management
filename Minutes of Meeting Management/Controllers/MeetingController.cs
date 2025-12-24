using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult MeetingList()
        {
            return View();
        }
        public IActionResult MeetingAddEdit()
        {
            return View();
        }
    }
}
