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
    public partial class addDoctorForm : Form
    {
        public addDoctorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = $"{textBox1.Text.Trim()}";
            string id_med = $"{textBox3.Text.Trim()}";
            string cabinet_number = $"{textBox2.Text.Trim()}";
            string reception_days = $"{textBox4.Text.Trim()}";
            string start_of_reception = $"{textBox5.Text.Trim()}";
            string end_of_reception = $"{textBox6.Text.Trim()}";
            string id_license = $"{textBox7.Text.Trim()}";

            string sqlcommand = $"INSERT INTO [dbo].[Doctors] VALUES " +
                $"(" +
                $"'{FIO}', " +
                $"{id_med}, " +
                $"{cabinet_number}, " +
                $"'{reception_days}', " +
                $"'{start_of_reception}', " +
                $"'{end_of_reception}', " +
                $"{id_license}) ";

            //MessageBox.Show(sqlcommand);

            try
            {
                sqlCommand1.CommandText = sqlcommand;
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Успешно добавил врача!");
            }
            catch
            {
                MessageBox.Show("Врача не добавили!\nПроверти правильность вводимых данных");
            }

        }
    }
}
