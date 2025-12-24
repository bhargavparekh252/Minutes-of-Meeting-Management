using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class MeetingVenueController : Controller
    {
        public IActionResult MeetingVenueList()
        {
            return View();
        }
        public IActionResult MeetingVenueAddEdit()
        {
            return View();
        }
    }
}
