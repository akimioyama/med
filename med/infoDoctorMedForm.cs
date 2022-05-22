using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med
{
    public partial class infoDoctorMedForm : Form
    {
        public infoDoctorMedForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zzz = comboBox1.Text;
            using (var connection = new SqlConnection("Data Source=LAPTOP-FPR118VN\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comm = connection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "infoDoctorMed";
                comm.Parameters.AddWithValue("@fio", zzz);
                DataTable dt = new DataTable();
                dt.Load(comm.ExecuteReader());
                dataGridView1.DataSource = dt.DefaultView;
                connection.Close();
            }
        }

        private void infoDoctorMedForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);

        }
    }
}
