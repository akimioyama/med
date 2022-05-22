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
    public partial class DiseaseForm : Form
    {
        public DiseaseForm()
        {
            InitializeComponent();
        }

        private void DiseaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet.Disease". При необходимости она может быть перемещена или удалена.
            this.diseaseTableAdapter.Fill(this.testDataSet.Disease);

        }
    }
}
