using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public List<SelectListItem> Skills { get; set; }

        public AddJobViewModel(string name, int employerId, List<SelectListItem> employers, List<SelectListItem> skills) {

            Name = name;
            EmployerId = employerId;
            Employers = employers;
            Skills = skills;
        
        }
    }
}
