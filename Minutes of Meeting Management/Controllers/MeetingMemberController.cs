using Microsoft.AspNetCore.Mvc;

namespace Minutes_of_Meeting_Management.Controllers
{
    public class MeetingMemberController : Controller
    {
        public IActionResult MeetingMemberList()
        {
            return View();
        }
        public IActionResult MeetingMemberAddEdit()
        {
            return View();
        }
    }
}
