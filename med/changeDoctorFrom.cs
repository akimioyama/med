using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace med
{
    public partial class changeDoctorFrom : Form
    {
        public changeDoctorFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            try
            {
                sqlCommand1.Parameters["@oldlic"].Value = Int32.Parse(label7.Text);
                sqlCommand1.Parameters["@newlic"].Value = Int32.Parse(label8.Text);
                sqlCommand1.Parameters["@idpol"].Value = Int32.Parse(label9.Text);

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Обновили!");
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка!\nПопробуйте проверить введёные данные\n{ex.Message}");
                sqlConnection1.Close();
            }
        }

        private void changeDoctorFrom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.testDataSet.Patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet._Patients_Doctors". При необходимости она может быть перемещена или удалена.
            this.patients_DoctorsTableAdapter.Fill(this.testDataSet._Patients_Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = $"FIO = '{comboBox1.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Doctors"].Select(qwe);
            try
            {
                label7.Text = result[0][6].ToString();
            }
            catch
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
                label8.Text = result[0][6].ToString();
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = $"FIO = '{comboBox3.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Patients"].Select(qwe);
            try
            {
                label9.Text = result[0][0].ToString();
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
