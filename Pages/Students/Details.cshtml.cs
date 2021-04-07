using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myWebApplication1.Data;
using myWebApplication1.Models;

namespace myWebApplication1.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly myWebApplication1.Data.myWebApplication1Context _context;

        public DetailsModel(myWebApplication1.Data.myWebApplication1Context context)
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

            Student = await _context.Student.FirstOrDefaultAsync(m => m.studentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
