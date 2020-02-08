using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_DojoSurveyModels.Models;

namespace C_Sharp_DojoSurveyModels.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Language { get; set; }
        public string Comment { get; set; }

    }
}