using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(SacramentPlanner.Models.SchoolContext context)
        {
            //_context = context;
        }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Student> Student { get; set; }
        public IList<Department> Department { get; set; }

        public void OnGet()
        {

        }
    }
}
