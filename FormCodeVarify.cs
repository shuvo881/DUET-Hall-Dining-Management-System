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
    public partial class FormCodeVarify : Form
    {
        public FormCodeVarify()
        {
            InitializeComponent();
        }
        string rndmCode,eml;
        char tblCkr;
        public FormCodeVarify(string rndmCodes,string email, char c)
        {
            InitializeComponent();
            rndmCode = rndmCodes;
            eml = email;
            tblCkr = c;

        }

        private void buttonCodeVerify_Click(object sender, EventArgs e)
        {
            
            if(rndmCode == textBoxCode.Text)
            {
                FormResetPassword rp = new FormResetPassword(eml,tblCkr);
                rp.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Your Varify Code is Worng...!");
            }
        }
    }
}
