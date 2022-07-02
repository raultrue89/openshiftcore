using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace aponshiftcore
{
    public class Conexion
    {
       public  MySqlConnection con = new MySqlConnection("Server=MYSQL5046.site4now.net;Database=db_a836f6_opshift;Uid=a836f6_opshift;Pwd=150M1238m;");
    }
}
