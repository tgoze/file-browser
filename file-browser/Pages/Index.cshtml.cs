using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace file_browser.Pages
{    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string[] files { get; set; }
    
        public void OnGet()
        {
            files = new string[]{"file1", "file2", "file3"};      
        }
    }
}
