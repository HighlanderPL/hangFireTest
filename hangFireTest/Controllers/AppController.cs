using hangFireTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangFireTest.Controllers
{
    public class AppController : Controller
    {
        private readonly HangFireTask _task;
        
        public AppController(HangFireTask task)
        {
            _task = task;
        }
        public IActionResult Index()
        {
            ViewBag.message = _task.message;
            ViewBag.now = _task.now;   
            return View();
        }
    }
}
