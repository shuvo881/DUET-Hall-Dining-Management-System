using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DUET_Hall_Dining_Management_System
{
    public partial class FormStudentSignup : Form
    {
        public FormStudentSignup()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp s = new FormSignUp();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDataRetrive dr = new ClassDataRetrive();
            foreach(string x in dr.UserNameGenerel())
            {
                if (textBoxUserName.Text == x || textBoxUserName.Text == "")
                {
                    MessageBox.Show("The user name is avalabe.So Please enter a new User name.");
                    return;
                }
            }

            foreach (string x in dr.UserNameAdmin())
            {
                if (textBoxUserName.Text+" Admin" == x )
                {
                    MessageBox.Show("The user name is avalabe.So Please enter a new User name.");
                    return;
                }
            }

            foreach (string x in dr.eMailGenerel())
            {
                if (textBoxEmail.Text == x || textBoxEmail.Text == "")
                {
                    MessageBox.Show("The Email is avalabe.So Please enter a new Email");
                    return;
                }
            }

            foreach (string x in dr.eMailAdmin())
            {
                if (textBoxEmail.Text == x )
                {
                    MessageBox.Show("The Email is avalabe.So Please enter a new Email.");
                    return;
                }
            }


            if (textBoxNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Your password length must be more then 6.");
                return;
            }
            if(textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Please enter same password between new password and current password.");
                return;
            }
            if(textBoxHallName.Text == "")
            {
                MessageBox.Show("Please, Enter a Hall Name.");
                return;
            }
            try
            {
                int a = Convert.ToInt32(textBoxRoomNo.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter valid room no.");
                return;
            }

            ClassDataStoreManagment cDSM = new ClassDataStoreManagment();
            if(cDSM.signupGenererl(this) == true)
            {
                MessageBox.Show("Registation Completed.");
                return;
            }
            MessageBox.Show("Registation Error...!");
            
        }
    }
}
