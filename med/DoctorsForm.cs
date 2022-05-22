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
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.testDataSet.Doctors);

        }
    }
}
