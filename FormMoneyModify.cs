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
    public partial class FormMoneyModify : Form
    {
        public FormMoneyModify()
        {
            InitializeComponent();
        }

        private void buttonShowMoney_Click(object sender, EventArgs e)
        {
            FormShowMoney sm = new FormShowMoney();
            this.Hide();
            sm.Show();
        }

        private void buttonUpdateMoney_Click(object sender, EventArgs e)
        {
            FormUpdateMoney um = new FormUpdateMoney();
            um.Show();
            this.Hide();
        }
    }
}
