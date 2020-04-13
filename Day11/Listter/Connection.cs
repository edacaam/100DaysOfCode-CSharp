using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Listter
{
    class Connection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-IGQJ2MA;Initial Catalog=Listter;Integrated Security=True");
            connect.Open();
            return connect;
        }
        
    }
}
