using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLSV
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("server=huyen;database=qlsv1;integrated security=true");
    }
}
