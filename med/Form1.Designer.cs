namespace med
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.больныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.болезниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колличествоБольныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПациентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ещёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВарчаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПациентуВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.testDataSet1 = new med.testDataSet();
            this.report2 = new FastReport.Report();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.ещёToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1);
            this.menuStrip1.Size = new System.Drawing.Size(1337, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.врачиToolStripMenuItem,
            this.больныеToolStripMenuItem,
            this.болезниToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(102, 33);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.врачиToolStripMenuItem.Text = "Врачи";
            this.врачиToolStripMenuItem.Click += new System.EventHandler(this.врачиToolStripMenuItem_Click);
            // 
            // больныеToolStripMenuItem
            // 
            this.больныеToolStripMenuItem.Name = "больныеToolStripMenuItem";
            this.больныеToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.больныеToolStripMenuItem.Text = "Больные";
            this.больныеToolStripMenuItem.Click += new System.EventHandler(this.больныеToolStripMenuItem_Click);
            // 
            // болезниToolStripMenuItem
            // 
            this.болезниToolStripMenuItem.Name = "болезниToolStripMenuItem";
            this.болезниToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.болезниToolStripMenuItem.Text = "Болезни";
            this.болезниToolStripMenuItem.Click += new System.EventHandler(this.болезниToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.колличествоБольныхToolStripMenuItem,
            this.информацияОПациентахToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(93, 33);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // колличествоБольныхToolStripMenuItem
            // 
            this.колличествоБольныхToolStripMenuItem.Name = "колличествоБольныхToolStripMenuItem";
            this.колличествоБольныхToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.колличествоБольныхToolStripMenuItem.Text = "Информация о пациентах";
            this.колличествоБольныхToolStripMenuItem.Click += new System.EventHandler(this.колличествоБольныхToolStripMenuItem_Click);
            // 
            // информацияОПациентахToolStripMenuItem
            // 
            this.информацияОПациентахToolStripMenuItem.Name = "информацияОПациентахToolStripMenuItem";
            this.информацияОПациентахToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.информацияОПациентахToolStripMenuItem.Text = "Отчет о болезнях";
            this.информацияОПациентахToolStripMenuItem.Click += new System.EventHandler(this.информацияОПациентахToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выпискаToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(100, 33);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // выпискаToolStripMenuItem
            // 
            this.выпискаToolStripMenuItem.Name = "выпискаToolStripMenuItem";
            this.выпискаToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.выпискаToolStripMenuItem.Text = "Выписка";
            this.выпискаToolStripMenuItem.Click += new System.EventHandler(this.выпискаToolStripMenuItem_Click);
            // 
            // ещёToolStripMenuItem
            // 
            this.ещёToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВрачаToolStripMenuItem,
            this.удалитьВарчаToolStripMenuItem,
            this.добавитьПациентаToolStripMenuItem,
            this.добавитьПациентуВрачаToolStripMenuItem});
            this.ещёToolStripMenuItem.Name = "ещёToolStripMenuItem";
            this.ещёToolStripMenuItem.Size = new System.Drawing.Size(64, 33);
            this.ещёToolStripMenuItem.Text = "Ещё";
            // 
            // добавитьВрачаToolStripMenuItem
            // 
            this.добавитьВрачаToolStripMenuItem.Name = "добавитьВрачаToolStripMenuItem";
            this.добавитьВрачаToolStripMenuItem.Size = new System.Drawing.Size(330, 28);
            this.добавитьВрачаToolStripMenuItem.Text = "Добавить врача";
            this.добавитьВрачаToolStripMenuItem.Click += new System.EventHandler(this.добавитьВрачаToolStripMenuItem_Click);
            // 
            // удалитьВарчаToolStripMenuItem
            // 
            this.удалитьВарчаToolStripMenuItem.Name = "удалитьВарчаToolStripMenuItem";
            this.удалитьВарчаToolStripMenuItem.Size = new System.Drawing.Size(330, 28);
            this.удалитьВарчаToolStripMenuItem.Text = "Удалить варча";
            this.удалитьВарчаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВарчаToolStripMenuItem_Click);
            // 
            // добавитьПациентаToolStripMenuItem
            // 
            this.добавитьПациентаToolStripMenuItem.Name = "добавитьПациентаToolStripMenuItem";
            this.добавитьПациентаToolStripMenuItem.Size = new System.Drawing.Size(330, 28);
            this.добавитьПациентаToolStripMenuItem.Text = "Добавить пациента";
            this.добавитьПациентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьПациентаToolStripMenuItem_Click);
            // 
            // добавитьПациентуВрачаToolStripMenuItem
            // 
            this.добавитьПациентуВрачаToolStripMenuItem.Name = "добавитьПациентуВрачаToolStripMenuItem";
            this.добавитьПациентуВрачаToolStripMenuItem.Size = new System.Drawing.Size(330, 28);
            this.добавитьПациентуВрачаToolStripMenuItem.Text = "Добавить пациенту врача";
            this.добавитьПациентуВрачаToolStripMenuItem.Click += new System.EventHandler(this.добавитьПациентуВрачаToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel2.BackgroundImage")));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1337, 726);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.button3, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.button4, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.button5, 1, 9);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(662, 720);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(38, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(586, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Информация о больном";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(38, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(586, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "ФИО леч. врача выбранного больного";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(38, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(586, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Информация о выбранном враче";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(38, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(586, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Список больных у выбранного врача";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(38, 588);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(586, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "Изменить лечащего врача";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.testDataSet1, "testDataSet1");
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report2
            // 
            this.report2.NeedRefresh = false;
            this.report2.ReportResourceString = resources.GetString("report2.ReportResourceString");
            this.report2.Tag = null;
            this.report2.RegisterData(this.testDataSet1, "testDataSet1");
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "mainForm";
            this.Text = "Работы над больными";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ещёToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem больныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem болезниToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private FastReport.Report report1;
        private System.Windows.Forms.ToolStripMenuItem колличествоБольныхToolStripMenuItem;
        private testDataSet testDataSet1;
        private System.Windows.Forms.ToolStripMenuItem информацияОПациентахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВрачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВарчаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПациентуВрачаToolStripMenuItem;
        private FastReport.Report report2;
    }
}

