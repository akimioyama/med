using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace med
{
    public partial class spr2 : Form
    {
        public spr2()
        {
            InitializeComponent();
        }

        private void spr2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Disease". При необходимости она может быть перемещена или удалена.
            this.diseaseTableAdapter.Fill(this.testDataSet.Disease);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet._Disease_Patuents". При необходимости она может быть перемещена или удалена.
            this.disease_PatuentsTableAdapter.Fill(this.testDataSet._Disease_Patuents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.testDataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zzz = $"{comboBox1.Text.Trim()}";
            string qqq = $"{comboBox2.Text.Trim()}";
           
            using (var connection = new SqlConnection("Data Source=LAPTOP-FPR118VN\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand comm = connection.CreateCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "spr2";
                comm.Parameters.AddWithValue("@fio", zzz);
                comm.Parameters.AddWithValue("@name", qqq);
                DataTable dt = new DataTable();
                dt.Load(comm.ExecuteReader());
                dataGridView1.DataSource = dt.DefaultView;
                connection.Close();
                int count = dataGridView1.RowCount;
                if (count != 0)
                {
                    string FIO = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    string ADRES = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    string NAME = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    string FIO1 = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    string DATAA = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    string DATE = DateTime.Now.ToShortDateString();

                    string TempFileNeme = "D:\\c#\\med\\spravka-027.docx";

                    var wordApp = new Word.Application();
                    wordApp.Visible = false;
                    try
                    {
                        var wordDoc = wordApp.Documents.Open(TempFileNeme);
                        ReplaceWordStub("<FIO>", FIO, wordDoc);
                        ReplaceWordStub("<ADRES>", ADRES, wordDoc);
                        ReplaceWordStub("<NAME>", NAME, wordDoc);
                        ReplaceWordStub("<FIO1>", FIO1, wordDoc);
                        ReplaceWordStub("<DATAA>", DATAA, wordDoc);
                        ReplaceWordStub("<DATE>", DATE, wordDoc);

                        wordDoc.SaveAs(@"D:\c#\med\result.docx");
                        wordApp.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
                else
                {
                    MessageBox.Show($"Внимание!\n{zzz} не болел(а) болезнью: {qqq}");
                }
                
            }

        }
        private void ReplaceWordStub(string stubToReplace, string text, 
            Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        
    }
}
