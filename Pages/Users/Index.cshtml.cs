using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksManager.Pages.Users
{
    public class IndexModel : PageModel
    {
        private Data.BooksDbContext _context { get; set; }
        public IndexModel(Data.BooksDbContext dbContext)
        {
            _context = dbContext;


        }


      public  List<Models.B_Users> list { get; set; }


        public void OnGet()
        {

              list = _context.Users.ToList();

        }
    }
}
