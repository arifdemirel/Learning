using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proje_Hastane
{
    class sqlconnection
    {
        public SqlConnection _conn_()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-KVIRVD3;Initial Catalog=Hastane;Integrated Security=True");
            connect.Open();
            return connect;
        }
    }
}
