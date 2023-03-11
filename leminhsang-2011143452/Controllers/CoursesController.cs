using leminhsang_2011143452.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace leminhsang_2011143452.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        
        public CoursesController()
        {
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            _dbcontext = applicationDbContext;
         }

        // GET: Courses
        public ActionResult Create()
        {
            return View();
        }
    }
}