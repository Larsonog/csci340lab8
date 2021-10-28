using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HalloweenSpookyUniversity2.Data;
using HalloweenSpookyUniversity2.Models;

namespace HalloweenSpookyUniversity2.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly HalloweenSpookyUniversity2.Data.SchoolContext _context;

        public DetailsModel(HalloweenSpookyUniversity2.Data.SchoolContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
