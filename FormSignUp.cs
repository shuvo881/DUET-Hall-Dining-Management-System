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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudentSignup sl = new FormStudentSignup();
            sl.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdminSingUP ass = new FormAdminSingUP();
            ass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManagment h = new FormManagment();
            h.Show();
            this.Close();
        }
    }
}
