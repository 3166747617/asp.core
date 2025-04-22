using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManage.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "I am a student";
        }
    }
}
