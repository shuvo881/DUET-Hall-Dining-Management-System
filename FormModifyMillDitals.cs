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
    public partial class FormModifyMillDitals : Form
    {
        public FormModifyMillDitals()
        {
            InitializeComponent();
        }

        private void buttonShowMillDitals_Click(object sender, EventArgs e)
        {
            FormShowMillDitals smd = new FormShowMillDitals();
            smd.Show();
            this.Hide();
        }

        private void buttonUpdateMill_Click(object sender, EventArgs e)
        {
            FormUpdateMill updtMill = new FormUpdateMill();
            this.Hide();
            updtMill.Show();
        }
    }
}
