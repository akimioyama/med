namespace med
{
    partial class DoctorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.testDataSet = new med.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new med.testDataSetTableAdapters.DoctorsTableAdapter();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinetnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiondaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startofreceptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endofreceptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlicenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1164, 670);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIODataGridViewTextBoxColumn,
            this.idmedDataGridViewTextBoxColumn,
            this.cabinetnumberDataGridViewTextBoxColumn,
            this.receptiondaysDataGridViewTextBoxColumn,
            this.startofreceptionDataGridViewTextBoxColumn,
            this.endofreceptionDataGridViewTextBoxColumn,
            this.idlicenseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 644);
            this.dataGridView1.TabIndex = 0;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО врача";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 125;
            // 
            // idmedDataGridViewTextBoxColumn
            // 
            this.idmedDataGridViewTextBoxColumn.DataPropertyName = "id_med";
            this.idmedDataGridViewTextBoxColumn.HeaderText = "Номер отделения";
            this.idmedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmedDataGridViewTextBoxColumn.Name = "idmedDataGridViewTextBoxColumn";
            this.idmedDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmedDataGridViewTextBoxColumn.Width = 125;
            // 
            // cabinetnumberDataGridViewTextBoxColumn
            // 
            this.cabinetnumberDataGridViewTextBoxColumn.DataPropertyName = "cabinet_number";
            this.cabinetnumberDataGridViewTextBoxColumn.HeaderText = "Номер кабинета";
            this.cabinetnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cabinetnumberDataGridViewTextBoxColumn.Name = "cabinetnumberDataGridViewTextBoxColumn";
            this.cabinetnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cabinetnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // receptiondaysDataGridViewTextBoxColumn
            // 
            this.receptiondaysDataGridViewTextBoxColumn.DataPropertyName = "reception_days";
            this.receptiondaysDataGridViewTextBoxColumn.HeaderText = "Дни приёма";
            this.receptiondaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receptiondaysDataGridViewTextBoxColumn.Name = "receptiondaysDataGridViewTextBoxColumn";
            this.receptiondaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiondaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // startofreceptionDataGridViewTextBoxColumn
            // 
            this.startofreceptionDataGridViewTextBoxColumn.DataPropertyName = "start_of_reception";
            this.startofreceptionDataGridViewTextBoxColumn.HeaderText = "Начало приёма";
            this.startofreceptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startofreceptionDataGridViewTextBoxColumn.Name = "startofreceptionDataGridViewTextBoxColumn";
            this.startofreceptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.startofreceptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // endofreceptionDataGridViewTextBoxColumn
            // 
            this.endofreceptionDataGridViewTextBoxColumn.DataPropertyName = "end_of_reception";
            this.endofreceptionDataGridViewTextBoxColumn.HeaderText = "Конец приёма";
            this.endofreceptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endofreceptionDataGridViewTextBoxColumn.Name = "endofreceptionDataGridViewTextBoxColumn";
            this.endofreceptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.endofreceptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idlicenseDataGridViewTextBoxColumn
            // 
            this.idlicenseDataGridViewTextBoxColumn.DataPropertyName = "id_license";
            this.idlicenseDataGridViewTextBoxColumn.HeaderText = "Номер лицензии";
            this.idlicenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idlicenseDataGridViewTextBoxColumn.Name = "idlicenseDataGridViewTextBoxColumn";
            this.idlicenseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlicenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 670);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoctorsForm";
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private testDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinetnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiondaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startofreceptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endofreceptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlicenseDataGridViewTextBoxColumn;
    }
}