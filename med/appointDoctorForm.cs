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
    public partial class appointDoctorForm : Form
    {
        public appointDoctorForm()
        {
            InitializeComponent();
        }

        private void appointDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.testDataSet.Patients);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = $"FIO = '{comboBox1.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Patients"].Select(qwe);
            try
            {
                label5.Text = result[0][0].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = $"FIO = '{comboBox2.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Doctors"].Select(qwe);
            try
            {
                label6.Text = result[0][6].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcommond = $"INSERT INTO [dbo].[Patients-Doctors] " +
                $"VALUES " +
                $"({label6.Text}, {label5.Text})";
            using (var connection = new SqlConnection("Data Source=LAPTOP-FPR118VN\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"))
            {

                
                    connection.Open();

                    SqlCommand comm = connection.CreateCommand();
                    comm.CommandText = sqlcommond;
                    comm.ExecuteNonQuery();

                    connection.Close();
                    MessageBox.Show("Добавили");
                
            }
        }
    }
}
