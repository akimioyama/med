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
    public partial class deleteDoctorForm : Form
    {
        public deleteDoctorForm()
        {
            InitializeComponent();
        }

        private void deleteDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(sqlcommand, "qqw");
            

            try
            {
                int i = int.Parse(label4.Text);

                sqlConnection1.Open();
                string sqlcommand = $"DELETE FROM Doctors " +
                $"WHERE Doctors.id_license = {i}";
                sqlCommand1.CommandText = sqlcommand;
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();

                MessageBox.Show("Успешно удалили врача!");
            }
            catch
            {
                MessageBox.Show("Врача не удалили!\nПроверьте, есть ли у него активные паценты");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qwe = $"FIO = '{comboBox1.Text.Trim()}'";
            DataRow[] result = testDataSet.Tables["Doctors"].Select(qwe);
            try
            {
                label4.Text = result[0][6].ToString();
            }
            catch 
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
