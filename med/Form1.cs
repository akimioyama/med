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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void болезниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiseaseForm diseaseForm = new DiseaseForm();
            diseaseForm.Show();
        }

        private void больныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoAboutPatientForm infoAboutPatientForm = new infoAboutPatientForm();
            infoAboutPatientForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            infoDoctorMedForm infoDoctorMedForm = new infoDoctorMedForm();
            infoDoctorMedForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            infoPatients1Form infoPatients1Form = new infoPatients1Form();
            infoPatients1Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeDoctorFrom changeDoctorFrom = new changeDoctorFrom();
            changeDoctorFrom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fioDoctorForm fioDoctorForm = new fioDoctorForm();
            fioDoctorForm.Show();
        }

        private void колличествоБольныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1.Show();
        }

        private void информацияОПациентахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выписатьПацентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spr2 spr2 = new spr2();
            spr2.Show();
        }

        private void добавитьВрачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDoctorForm addDoctorForm = new addDoctorForm();
            addDoctorForm.Show();
        }

        private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPatientsForm addPatientsForm = new addPatientsForm();
            addPatientsForm.Show();
        }

        private void удалитьВарчаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDoctorForm deleteDoctorForm = new deleteDoctorForm();
            deleteDoctorForm.Show();
        }

        private void добавитьПациентуВрачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointDoctorForm appointDoctorForm = new appointDoctorForm();
            appointDoctorForm.Show();
        }

        private void выгрузитьБольныхEXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
