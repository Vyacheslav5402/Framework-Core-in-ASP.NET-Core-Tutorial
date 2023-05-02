using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial_1_of_8.Models;

namespace Tutorial_1_of_8.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly Tutorial_1_of_8.Data.SchoolContext _context;

        public IndexModel(Tutorial_1_of_8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
