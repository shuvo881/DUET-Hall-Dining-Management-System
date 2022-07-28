using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DUET_Hall_Dining_Management_System
{
    class ClassDatabase
    {
        string connecttingStr = "Data Source=DESKTOP-VA8ASIP\\MSSQLSERVER01;Initial Catalog=Dining_Management;Integrated Security=True";
        SqlConnection connected = null;

        public ClassDatabase()
        {
            connected = new SqlConnection(connecttingStr);
        }

        public SqlConnection connector()
        {
            return connected;
        }


    }
}
