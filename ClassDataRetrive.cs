using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DUET_Hall_Dining_Management_System
{

    class ClassDataRetrive
    {
        
        ClassDatabase dbConctor = null;
        SqlConnection connction = null;
        public ClassDataRetrive()
        {
            dbConctor = new ClassDatabase();
            connction = dbConctor.connector(); 
        }

        public List<string> UserNameGenerel()
        {
            List<string> listStr = new List<string>();

            connction.Open();
            string qry = "SELECT u.user_name FROM  user_ditals as u";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listStr.Add(rdr["user_name"].ToString());
            }

            connction.Close();
            return listStr;
        }
        public string passwordForUsername(string x)
        {
            
            connction.Open();
            string qry = "SELECT u.password FROM  user_ditals as u WHERE user_name = '"+x+"'";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();
            string s = null;
            if (rdr.Read())
            {
                s = rdr["password"].ToString();
                connction.Close();
                return s;
            }
            connction.Close();
            return s;
        }

        public string passwordForAdmin(string x)
        {

            connction.Open();
            string qry = "SELECT u.password FROM  Admin_ditals as u WHERE user_name = '" + x + "'";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();
            string s = null;
            if (rdr.Read())
            {
                s = rdr["password"].ToString();
                connction.Close();
                return s;
            }
            connction.Close();
            return s;
        }

        public List<string> eMailGenerel()
        {
            List<string> listStr = new List<string>();

            connction.Open();
            string qry = "SELECT u.email FROM  user_ditals as u";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listStr.Add(rdr["email"].ToString());
            }

            connction.Close();
            return listStr;
        }

        public string skrtKey()
        {
            connction.Open();
            
            string qry = "SELECT skrtKey FROM secrutKey";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string str = rdr["skrtKey"].ToString();
                connction.Close();
                return str;
            }
            return null;
            
            
            
        }
        public List<string> UserNameAdmin()
        {
            List<string> listStr = new List<string>();

            connction.Open();
            string qry = "SELECT u.user_name FROM  Admin_ditals as u";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listStr.Add(rdr["user_name"].ToString());
            }

            connction.Close();
            return listStr;
        }
        public List<string> eMailAdmin()
        {
            List<string> listStr = new List<string>();

            connction.Open();
            string qry = "SELECT u.email FROM  Admin_ditals as u";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listStr.Add(rdr["email"].ToString());
            }

            connction.Close();
            return listStr;
        }
        public string singlAdminUserName(string eml)
        {

            connction.Open();
            string qry = "SELECT user_name FROM  Admin_ditals WHERE email = '"+eml+"'";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string s = rdr["user_name"].ToString();
                connction.Close();
                string[] str = s.Split(new[] { "Admin" }, StringSplitOptions.None);// because of 'Admin' word from user_name.;
                return str[0];
            }
            connction.Close();
            return null;
        }
        public string singlGenerelUserName(string eml)
        {

            connction.Open();
            string qry = "SELECT user_name FROM  user_ditals WHERE email = '"+eml+"'";
            SqlCommand cmd = new SqlCommand(qry, connction);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                string s = rdr["user_name"].ToString();
                connction.Close();
                return s;
            }
            connction.Close();
            return null;
        }

        

    }
}
