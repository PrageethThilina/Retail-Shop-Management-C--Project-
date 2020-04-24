namespace Group_Project
{
    partial class Suplyer
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
            this.lblSupID = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSupAddress = new System.Windows.Forms.Label();
            this.lblSupConNum = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SupDetailGrid = new System.Windows.Forms.DataGridView();
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupConNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupDetailGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupID.Location = new System.Drawing.Point(66, 41);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(94, 20);
            this.lblSupID.TabIndex = 0;
            this.lblSupID.Text = "Suplier  ID";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.Location = new System.Drawing.Point(66, 82);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(116, 20);
            this.lblSupName.TabIndex = 1;
            this.lblSupName.Text = "Suplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // lblSupAddress
            // 
            this.lblSupAddress.AutoSize = true;
            this.lblSupAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupAddress.Location = new System.Drawing.Point(66, 167);
            this.lblSupAddress.Name = "lblSupAddress";
            this.lblSupAddress.Size = new System.Drawing.Size(136, 20);
            this.lblSupAddress.TabIndex = 3;
            this.lblSupAddress.Text = "Suplier Address";
            // 
            // lblSupConNum
            // 
            this.lblSupConNum.AutoSize = true;
            this.lblSupConNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupConNum.Location = new System.Drawing.Point(66, 122);
            this.lblSupConNum.Name = "lblSupConNum";
            this.lblSupConNum.Size = new System.Drawing.Size(200, 20);
            this.lblSupConNum.TabIndex = 4;
            this.lblSupConNum.Text = "Suplier Contact Number";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(329, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(329, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtConNum
            // 
            this.txtConNum.Location = new System.Drawing.Point(329, 114);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(222, 20);
            this.txtConNum.TabIndex = 7;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(329, 167);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(222, 77);
            this.txtAdd.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(67, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(219, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(359, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(532, 267);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SupDetailGrid
            // 
            this.SupDetailGrid.AllowUserToAddRows = false;
            this.SupDetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupID,
            this.SupName,
            this.SupConNum,
            this.SupAdd});
            this.SupDetailGrid.Location = new System.Drawing.Point(73, 307);
            this.SupDetailGrid.Name = "SupDetailGrid";
            this.SupDetailGrid.RowHeadersWidth = 5;
            this.SupDetailGrid.Size = new System.Drawing.Size(606, 150);
            this.SupDetailGrid.TabIndex = 13;
            // 
            // SupID
            // 
            this.SupID.HeaderText = "Suplier ID";
            this.SupID.Name = "SupID";
            this.SupID.Width = 150;
            // 
            // SupName
            // 
            this.SupName.HeaderText = "Suplier Name";
            this.SupName.Name = "SupName";
            this.SupName.Width = 150;
            // 
            // SupConNum
            // 
            this.SupConNum.HeaderText = "Suplier Contact Number";
            this.SupConNum.Name = "SupConNum";
            this.SupConNum.Width = 150;
            // 
            // SupAdd
            // 
            this.SupAdd.HeaderText = "Suplier Address";
            this.SupAdd.Name = "SupAdd";
            this.SupAdd.Width = 150;
            // 
            // Suplyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.SupDetailGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtConNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSupConNum);
            this.Controls.Add(this.lblSupAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblSupID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Suplyer";
            this.Text = "Suplyer Registation";
            this.Load += new System.EventHandler(this.Suplyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSupAddress;
        private System.Windows.Forms.Label lblSupConNum;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtConNum;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView SupDetailGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupConNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupAdd;
    }
}