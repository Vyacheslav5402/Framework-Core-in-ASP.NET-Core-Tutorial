﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial_1_of_8.Data;
using Tutorial_1_of_8.Models;

namespace Tutorial_1_of_8.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly Tutorial_1_of_8.Data.SchoolContext _context;

        public IndexModel(Tutorial_1_of_8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Departments != null)
            {
                Department = await _context.Departments
                .Include(d => d.Administrator).ToListAsync();
            }
        }
    }
}
