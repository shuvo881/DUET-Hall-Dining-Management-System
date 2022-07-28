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
    public partial class FormUpdateMill : Form
    {
        ClassDatabase db = null;
        SqlConnection connection = null;
        DataTable dtaTbl = null;
        SqlDataAdapter sqlData = null;
        public FormUpdateMill()
        {
            ClassDatabase db = new ClassDatabase();
            connection = db.connector();
            InitializeComponent();
        }


        private void FormUpdateMill_Load(object sender, EventArgs e)
        {
            connection.Open();
            sqlData = new SqlDataAdapter("Select * From mill_Counter", connection);
            dtaTbl = new DataTable();
            sqlData.Fill(dtaTbl);

            

            dataGridView1.DataSource = dtaTbl;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommandBuilder cmdb = new SqlCommandBuilder(sqlData);
                sqlData.Update(dtaTbl);
                connection.Close();
                MessageBox.Show("Data save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error) ; 
            }
        }

        
    }
}
