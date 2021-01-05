using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        // GET: /<controller>/
        private JobDbContext context;
        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add(string name, string location)
        {
            AddEmployerViewModel employerModel = new AddEmployerViewModel(name, location);
            return View(employerModel);
        }

        public IActionResult ProcessAddEmployerForm()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            return View();
        }
    }
}
