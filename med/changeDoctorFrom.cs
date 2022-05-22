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
            string qqq = $"FIO = '{comboBox1.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Doctors"].Select(qqq);

            string zzz = $"FIO = '{comboBox2.Text.Trim()}'";
            DataRow[] result1 = testDataSet.Tables["Doctors"].Select(qqq);

            try
            {
                sqlCommand1.Parameters["@newlic"].Value = Int32.Parse(result[0][6].ToString());
                sqlCommand1.Parameters["@oldlic"].Value = Int32.Parse(result1[0][6].ToString());
                sqlCommand1.Parameters["@idpol"].Value = Int32.Parse(comboBox3.Text);

                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Обновили!");
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПопробуйте проверить введёные данные");
                sqlConnection1.Close();
            }
        }

        private void changeDoctorFrom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet._Patients_Doctors". При необходимости она может быть перемещена или удалена.
            this.patients_DoctorsTableAdapter.Fill(this.testDataSet._Patients_Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);

        }
    }
}
