namespace Group_Project
{
    partial class Employee_Attendence_View_Page
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTotDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWorkingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Emp Id"});
            this.comboBox1.Location = new System.Drawing.Point(210, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.comboBox2.Location = new System.Drawing.Point(448, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox3.Location = new System.Drawing.Point(448, 84);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEmpId,
            this.DgEmpName,
            this.dgYear,
            this.dgMonth,
            this.dgTotDays,
            this.dgWorkingDays,
            this.dgPresent,
            this.dgAbsent,
            this.dgLop});
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // dgEmpId
            // 
            this.dgEmpId.HeaderText = "Emp Id";
            this.dgEmpId.Name = "dgEmpId";
            // 
            // DgEmpName
            // 
            this.DgEmpName.HeaderText = "Name";
            this.DgEmpName.Name = "DgEmpName";
            // 
            // dgYear
            // 
            this.dgYear.HeaderText = "Year";
            this.dgYear.Name = "dgYear";
            // 
            // dgMonth
            // 
            this.dgMonth.HeaderText = "Month";
            this.dgMonth.Name = "dgMonth";
            // 
            // dgTotDays
            // 
            this.dgTotDays.HeaderText = "Total Days";
            this.dgTotDays.Name = "dgTotDays";
            // 
            // dgWorkingDays
            // 
            this.dgWorkingDays.HeaderText = "Working Days";
            this.dgWorkingDays.Name = "dgWorkingDays";
            // 
            // dgPresent
            // 
            this.dgPresent.HeaderText = "Present";
            this.dgPresent.Name = "dgPresent";
            // 
            // dgAbsent
            // 
            this.dgAbsent.HeaderText = "Absent Days";
            this.dgAbsent.Name = "dgAbsent";
            // 
            // dgLop
            // 
            this.dgLop.HeaderText = "Lop Days";
            this.dgLop.Name = "dgLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Month";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Employee_Attendence_View_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Employee_Attendence_View_Page";
            this.Text = "Employee Attendence View";
            this.Load += new System.EventHandler(this.Employee_Attendence_View_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTotDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWorkingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLop;
    }
}