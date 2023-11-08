using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garage2._0_Group5.Data;
using Garage2._0_Group5.Models.Entities;

namespace Garage2._0_Group5.Controllers
{
    public class TimerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
