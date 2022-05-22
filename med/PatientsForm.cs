using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace med
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.testDataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xlApp = new Excel.Application();

            xlApp.Application.Workbooks.Add(Type.Missing);
            xlApp.Columns.ColumnWidth = 25;

            Excel.Worksheet wsh = (Excel.Worksheet)xlApp.ActiveSheet;

            
            xlApp.Cells[1, 1] = "Номер мед. страховки";
            xlApp.Cells[1, 2] = "Фамилия Имя Очество";
            xlApp.Cells[1, 3] = "Адрес";
            xlApp.Cells[1, 4] = "Номер медицинской организации";


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    wsh.Cells[i + 2, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            xlApp.Visible = true;
        }
    }
}
