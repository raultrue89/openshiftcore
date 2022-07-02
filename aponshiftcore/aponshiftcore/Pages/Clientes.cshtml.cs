using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aponshiftcore;
using aponshiftcore.Data;
using Dapper;

namespace aponshiftcore.Pages
{
    public class ClientesModel : PageModel
    {
        private Conexion con = new Conexion();

        public ClientesModel()
        {
            
        }

        public IActionResult OnGet()
        {
            getclientes();
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; }
        [BindProperty]
        public List<Cliente> Clientes { get; set; }

        void getclientes()
        {
            using(var db= con.con)
            {
                var result = db.Query<Cliente>("select * from clientes");
                Clientes = result.ToList();
            }
        }
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using(var db = con.con)
            {
                db.Execute($"CALL insertarCliente('{Cliente.Nombre}','{Cliente.Apellidos}', '{Cliente.Telefono}', '{Cliente.Telefono2}', '{Cliente.Calle}', '{Cliente.Numero}', '{Cliente.Colonia}', '{Cliente.Municipio}', '{Cliente.Pais}', '{Cliente.Estado}')");
            }
            getclientes();
            return Page();
        }
    }
}
