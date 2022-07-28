using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DUET_Hall_Dining_Management_System
{
    class ClassDataStoreManagment
    {
        ClassDatabase dbConctor = null;
        SqlConnection connction = null;
        public ClassDataStoreManagment()
        {
            dbConctor = new ClassDatabase();
            connction = dbConctor.connector();
            

        }

        public bool signupGenererl(FormStudentSignup  ss)
        {
            connction.Open();
            string insertQury = "INSERT INTO user_ditals VALUES( '"+ss.textBoxUserName.Text+"','"+ss.textBoxNewPassword.Text+"','"+ss.textBoxEmail.Text+"','"+ss.textBoxHallName.Text+"','"+Convert.ToInt32(ss.textBoxRoomNo.Text)+"')";
            SqlCommand sCmd = new SqlCommand(insertQury, connction);
            SqlCommand cmd = new SqlCommand("INSERT INTO mill_Counter (userName) VALUES( '" + ss.textBoxUserName.Text + "')", connction);
            SqlCommand cm = new SqlCommand("INSERT INTO Cash (userName) VALUES( '" + ss.textBoxUserName.Text + "')", connction);
            try
            {
                cm.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                sCmd.ExecuteNonQuery();
            }
            catch
            {
                connction.Close();
                return false;
            }
            connction.Close();
            return true;
        }
        public bool signupAdmin(FormAdminSingUP asu)
        {
            connction.Open();
            string insertQury = "INSERT INTO Admin_ditals VALUES( '" + (asu.textBoxUserName.Text+" Admin") + "','" + asu.textBoxNewPassword.Text + "','" + asu.textBoxEmail.Text +"')";
            SqlCommand sCmd = new SqlCommand(insertQury, connction);
            SqlCommand cmd = new SqlCommand("INSERT INTO mill_Counter (userName) VALUES( '" + asu.textBoxUserName.Text +" Admin"+"')", connction);
            SqlCommand cm = new SqlCommand("INSERT INTO Cash (userName) VALUES( '" + asu.textBoxUserName.Text + "')", connction);
            try 
            {
                cm.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                sCmd.ExecuteNonQuery();
            }
            catch
            {
                connction.Close();
                return false;
            }
            connction.Close();
            return true;
        }

        public bool updatePasswordAdmin(string pass, string eml)
        {
            connction.Open();

            SqlCommand cmd = new SqlCommand("Update Admin_ditals SET [password] = '"+pass+"' Where [email] = '"+eml+"' ", connction);
           
            try
            {
                cmd.ExecuteNonQuery();
                connction.Close();
                return true;
            }
            catch
            {
                connction.Close();
                return false;
            }
          
        }
        public bool updatePasswordGenerel(string pass, string eml)
        {
            connction.Open();

            SqlCommand cmd = new SqlCommand("Update user_ditals SET [password] = '" + pass + "' Where [email] = '" + eml + "' ", connction);

            try
            {
                cmd.ExecuteNonQuery();
                connction.Close();
                return true;
            }
            catch
            {
                connction.Close();
                return false;
            }

        }
    }
}
