using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }

        [HttpPost("result")]
        public ViewResult ResultPage(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View();
        }
    }
}