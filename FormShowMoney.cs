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
    public partial class FormShowMoney : Form
    {
        public FormShowMoney()
        {
            InitializeComponent();
        }

        private void FormShowMoney_Load(object sender, EventArgs e)
        {
            ClassDatabase db = new ClassDatabase();
            SqlConnection connection = db.connector();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select * From Cash", connection);
            DataTable dtaTbl = new DataTable();
            sqlData.Fill(dtaTbl);
            dataGridView1.DataSource = dtaTbl;
            connection.Close();
        }
    }
}
