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
    public partial class FormManagment : Form
    {
        public FormManagment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp s = new FormSignUp();
            s.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin l = new FormLogin();
            l.Show();
            this.Hide();
        }
    }
}
