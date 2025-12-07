namespace MyCrud
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btUpd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btReport = new System.Windows.Forms.Button();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_hello = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLnameSearch = new System.Windows.Forms.TextBox();
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.sdReport = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.cmGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btUpd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtBirthDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbFname);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbLname);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 129);
            this.panel1.TabIndex = 0;
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(716, 41);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(75, 23);
            this.btUpd.TabIndex = 12;
            this.btUpd.Text = "Изменить";
            this.btUpd.UseCompatibleTextRendering = true;
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пол";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.cbGender.Location = new System.Drawing.Point(531, 87);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(144, 21);
            this.cbGender.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(531, 61);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(144, 20);
            this.dtBirthDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(531, 34);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(144, 20);
            this.tbFname.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(716, 10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseCompatibleTextRendering = true;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(531, 8);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(144, 20);
            this.tbLname.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Controls.Add(this.btReport);
            this.panel3.Controls.Add(this.cbReportType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(797, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 129);
            this.panel3.TabIndex = 1;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(73, 55);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(75, 23);
            this.btReport.TabIndex = 1;
            this.btReport.Text = "скачать";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // cbReportType
            // 
            this.cbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReportType.FormattingEnabled = true;
            this.cbReportType.Items.AddRange(new object[] {
            "EXCEL",
            "CSV"});
            this.cbReportType.Location = new System.Drawing.Point(44, 15);
            this.cbReportType.Name = "cbReportType";
            this.cbReportType.Size = new System.Drawing.Size(121, 21);
            this.cbReportType.TabIndex = 0;
            this.cbReportType.SelectedIndexChanged += new System.EventHandler(this.cbReportType_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.bt_hello);
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbLnameSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 129);
            this.panel2.TabIndex = 0;
            // 
            // bt_hello
            // 
            this.bt_hello.Location = new System.Drawing.Point(256, 65);
            this.bt_hello.Name = "bt_hello";
            this.bt_hello.Size = new System.Drawing.Size(75, 23);
            this.bt_hello.TabIndex = 3;
            this.bt_hello.Text = "привет";
            this.bt_hello.UseVisualStyleBackColor = true;
            this.bt_hello.Click += new System.EventHandler(this.bt_hello_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(256, 28);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Найти";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // tbLnameSearch
            // 
            this.tbLnameSearch.Location = new System.Drawing.Point(91, 28);
            this.tbLnameSearch.Name = "tbLnameSearch";
            this.tbLnameSearch.Size = new System.Drawing.Size(144, 20);
            this.tbLnameSearch.TabIndex = 0;
            // 
            // gvStudent
            // 
            this.gvStudent.AllowUserToAddRows = false;
            this.gvStudent.AllowUserToDeleteRows = false;
            this.gvStudent.BackgroundColor = System.Drawing.Color.Yellow;
            this.gvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fi,
            this.birthdate,
            this.gender});
            this.gvStudent.ContextMenuStrip = this.cmGV;
            this.gvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStudent.Location = new System.Drawing.Point(0, 129);
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.ReadOnly = true;
            this.gvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudent.Size = new System.Drawing.Size(998, 593);
            this.gvStudent.TabIndex = 1;
            this.gvStudent.SelectionChanged += new System.EventHandler(this.gvStudent_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fi
            // 
            this.fi.DataPropertyName = "fi";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fi.DefaultCellStyle = dataGridViewCellStyle2;
            this.fi.HeaderText = "Фамилия имя";
            this.fi.Name = "fi";
            this.fi.ReadOnly = true;
            this.fi.Width = 200;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "birthdate";
            this.birthdate.HeaderText = "Дата рождения";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            this.birthdate.Width = 150;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // cmGV
            // 
            this.cmGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miDelete});
            this.cmGV.Name = "cmGV";
            this.cmGV.Size = new System.Drawing.Size(129, 70);
            // 
            // miAdd
            // 
            this.miAdd.Name = "miAdd";
            this.miAdd.Size = new System.Drawing.Size(128, 22);
            this.miAdd.Text = "Добавить";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.Size = new System.Drawing.Size(128, 22);
            this.miEdit.Text = "Изменить";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.Size = new System.Drawing.Size(128, 22);
            this.miDelete.Text = "Удалить";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 722);
            this.Controls.Add(this.gvStudent);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.cmGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLnameSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.ContextMenuStrip cmGV;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.SaveFileDialog sdReport;
        private System.Windows.Forms.Button bt_hello;
    }
}

