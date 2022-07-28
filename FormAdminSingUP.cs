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
    public partial class FormAdminSingUP : Form
    {
        public FormAdminSingUP()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSignUp s = new FormSignUp();
            s.Show();
            this.Hide();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ClassDataRetrive dr = new ClassDataRetrive();

            if(textBoxSecurtKey.Text != dr.skrtKey())
            {
                //MessageBox.Show(dr.skrtKey());
                MessageBox.Show("Please Enter The valid Securt Key.");
                return;
            }

            

            foreach (string x in dr.UserNameAdmin())
            {
                if (textBoxUserName.Text+" Admin" == x || textBoxUserName.Text == "")
                {
                    MessageBox.Show("The user name is avalabe.So Please enter a new User name.");
                    return;
                }
            }

            foreach (string x in dr.UserNameGenerel())
            {
                if (textBoxUserName.Text == x )
                {
                    MessageBox.Show("The user name is avalabe.So Please enter a new User name.");
                    return;
                }
            }

            foreach (string x in dr.eMailAdmin())
            {
                if (textBoxEmail.Text == x || textBoxEmail.Text == null)
                {
                    MessageBox.Show("The Email is avalabe.So Please enter a new Email.");
                    return;
                }
            }

            foreach (string x in dr.eMailGenerel())
            {
                if (textBoxEmail.Text == x || textBoxEmail.Text == null)
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
            if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Please enter same password between new password and current password.");
                return;
            }

            //this.textBoxUserName.Text = this.textBoxUserName.Text + " Admin";

            ClassDataStoreManagment cDSM = new ClassDataStoreManagment();
            if(cDSM.signupAdmin(this) == true)
            {
                MessageBox.Show("Registation Completed.");
                return;
            }
            MessageBox.Show("Registation Error...!");

        }
    }
}
