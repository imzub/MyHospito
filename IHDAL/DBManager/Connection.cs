using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Conn
{
    public class Connection
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(local)\SQLEXPRESS;Initial Catalog=HospitoDb;Integrated Security=True";
        }
    }
}
