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
    public partial class addPatientsForm : Form
    {
        public addPatientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = $"{textBox1.Text.Trim()}";
            string id_insurance_policy = $"{textBox2.Text.Trim()}";
            string insurance_comp_number = $"{textBox3.Text.Trim()}";
            string adres = $"{textBox4.Text.Trim()}";


            string sqlcommand = $"INSERT INTO [dbo].[Patients] VALUES (" +
                $"{id_insurance_policy}, " +
                $"'{FIO}', " +
                $"'{adres}', " +
                $"{insurance_comp_number})";

            //MessageBox.Show(sqlcommand);

            try
            {
                sqlCommand1.CommandText = sqlcommand;
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                MessageBox.Show("Успешно добавил пациента!");
            }
            catch
            {
                MessageBox.Show("Пациента не добавили!\nПроверти правильность вводимых данных");
            }
        }
    }
}
