using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUET_Hall_Dining_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagment h = new FormManagment();
            h.Show();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            //textBoxUserName.Text = "";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //textBoxPassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxUserName.Text == "")
            {
                MessageBox.Show("Please, Enter User Name");
                return;
            }

            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please, Enter Password");
                return;
            }

            ClassDataRetrive dr = new ClassDataRetrive();
            foreach (string x in dr.UserNameGenerel())
            {
                if (textBoxUserName.Text == x)
                {
                    if (textBoxPassword.Text == dr.passwordForUsername(textBoxUserName.Text))
                    {
                        FormAdminHome h = new FormAdminHome();
                        h.Show();
                        this.Hide();
                        return;
                    }
                 

                    
                }
            }
            foreach (string x in dr.UserNameAdmin())
            {
                if (textBoxUserName.Text+" Admin" == x)
                {
                    if (textBoxPassword.Text == dr.passwordForAdmin(x))
                    {
                        FormAdminHome h = new FormAdminHome();
                        h.Show();
                        this.Hide();
                        return;
                    }



                }
            }
            MessageBox.Show("Please Enter a valid Username And Password ");

        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            FormEmailVarify fm = new FormEmailVarify();
            this.Hide();
            fm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormSignUp su = new FormSignUp();
            su.Show();
            this.Close();
        }
    }
}
