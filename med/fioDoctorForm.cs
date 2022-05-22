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


namespace med
{
    public partial class fioDoctorForm : Form
    {
        public fioDoctorForm()
        {
            InitializeComponent();
        }

        private void fioDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.testDataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zzz = comboBox1.Text;
            using (var connection = new SqlConnection("Data Source=LAPTOP-FPR118VN\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comm = connection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "fioDoctor";
                comm.Parameters.AddWithValue("@fio", zzz);
                DataTable dt = new DataTable();
                dt.Load(comm.ExecuteReader());
                dataGridView1.DataSource = dt.DefaultView;
                connection.Close();
            }
        }
    }
}
