using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace universityPortal
{
    class Class2
    {


        public static SqlConnection sql = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=universityportal;Integrated Security=True");

    }
}
