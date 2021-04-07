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
    public class IndexModel : PageModel
    {
        private readonly myWebApplication1.Data.myWebApplication1Context _context;

        public IndexModel(myWebApplication1.Data.myWebApplication1Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
