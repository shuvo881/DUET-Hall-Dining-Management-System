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
    public partial class FormResetPassword : Form
    {
        public FormResetPassword()
        {
            InitializeComponent();
        }
        string eml;
        char tblCkr;

        public FormResetPassword(string em, char c)
        {
            InitializeComponent();
            eml = em;
            tblCkr = c;
        }

        private void buttonSucces_Click(object sender, EventArgs e)
        {
            
            ClassDataStoreManagment dsm = new ClassDataStoreManagment();
            if(textBoxNewPassword.Text == textBoxVarifyPassword.Text)
            {
                if(tblCkr == 'A')
                {
                    if(dsm.updatePasswordAdmin(textBoxNewPassword.Text, eml) == true)
                    {
                        MessageBox.Show("Password reset successfully");
                        FormLogin l = new FormLogin();
                        this.Hide();
                        l.Show();
                        return;
                    }
                    MessageBox.Show("somthing error, try again");
                    return;
                }
                else if(tblCkr == 'G')
                {
                    if(dsm.updatePasswordGenerel(textBoxNewPassword.Text, eml) == true)
                    {
                        MessageBox.Show("Password reset successfully");
                        FormLogin l = new FormLogin();
                        this.Hide();
                        l.Show();
                        return;
                    }
                    MessageBox.Show("somthing error, try again");
                    return;
                }
                else
                {
                    MessageBox.Show("somthing error..!");
                }
            }
            else
            {
                MessageBox.Show("Enter same paswword into new and confirm password");
            }
        }
    }
}
