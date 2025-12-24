using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class MeetingTypeController : Controller
    {
        public IActionResult MeetingTypeList()
        {
            return View();
        }
        public IActionResult MeetingTypeAddEdit()
        {
            return View();
        }
    }
}
