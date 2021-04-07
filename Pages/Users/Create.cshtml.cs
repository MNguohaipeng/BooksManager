using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BooksManager.Pages.Users
{
    public class CreateModel : PageModel
    {

        private Data.BooksDbContext _context { get; set; }
        public CreateModel(Data.BooksDbContext dbContext)
        {

            _context = dbContext;
        }

        public void OnGet()
        {
            user = new Models.B_Users();
        }

        [BindProperty]
        public Models.B_Users user { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");

        }
    }
}
