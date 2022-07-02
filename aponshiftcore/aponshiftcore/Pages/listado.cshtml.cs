using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aponshiftcore;
using aponshiftcore.Data;

namespace aponshiftcore.Pages
{
    public class listadoModel : PageModel
    {
     

        public listadoModel()
        {
           
        }

        public IList<Cliente> Cliente { get;set; }

        public async Task OnGetAsync()
        {
          
        }
    }
}
