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
    public partial class FormAdminHome : Form
    {
        public FormAdminHome()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin l = new FormLogin();
            l.Show();
        }

        private void buttonMillDitals_Click(object sender, EventArgs e)
        {
            FormModifyMillDitals mmd = new FormModifyMillDitals();
            this.Hide();
            mmd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMoneyModify mm = new FormMoneyModify();
            mm.Show();
            this.Hide();
        }
    }
}
