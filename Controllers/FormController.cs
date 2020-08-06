using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class FormController : Controller
    {
        [HttpGet("")]
        public ViewResult Form()
        {
            return View("Form");
        }

        [HttpPost("result")]
        public ViewResult Result(string name, string location, string language, string comments)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comments;
            return View("Results");
        }
    }
}