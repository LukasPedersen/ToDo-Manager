using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_Manager.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> s { get; set; }

        public IndexModel()
        {
            this.s = new List<string>();
            s.Add("Hello");
            s.Add("Hello");
            s.Add("Hello");
        }

        public void OnGet()
        {
            
        }
    }
}
