using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class FormController : Controller
    {
        [HttpGet("")]
        public ViewResult Form()
        {
            return View("Form");
        }

        [HttpPost("result")]
        public ViewResult Result(Info FormInfo)
        {
            return View("Results", FormInfo);
        }
    }
}