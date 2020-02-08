using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_DojoSurveyModels.Models;

namespace C_Sharp_DojoSurveyModels.Controllers
{
    public class OutputController : Controller
    {
// One way:
    // [HttpPost("survey")]
    // public IActionResult Survey(string Name, string Location, string Language, string Comment)
    // {
    //     User yourUser = new User()
    //     {
    //         Name = Name,
    //         Location = Location,
    //         Language = Language,
    //         Comment = Comment
    //     };
    //     return View("Survey", yourUser);
    // }

// Another way:
        [HttpPost("survey")]
        public IActionResult Survey(User yourUser)
        {
            return View("Survey", yourUser);
        }
    }
}
