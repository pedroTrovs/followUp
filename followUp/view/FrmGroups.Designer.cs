
namespace followUp.view
{
    partial class FrmGroups
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
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.cboClassDay = new System.Windows.Forms.ComboBox();
            this.dtpClassTIme = new System.Windows.Forms.DateTimePicker();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.lblClassDay = new System.Windows.Forms.Label();
            this.lblClassTime = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.cboBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(12, 47);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.ReadOnly = true;
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(330, 311);
            this.dgvGroups.TabIndex = 2;
            this.dgvGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellDoubleClick);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(525, 58);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 20);
            this.txtGroupName.TabIndex = 3;
            // 
            // cboClassDay
            // 
            this.cboClassDay.FormattingEnabled = true;
            this.cboClassDay.Location = new System.Drawing.Point(525, 90);
            this.cboClassDay.Name = "cboClassDay";
            this.cboClassDay.Size = new System.Drawing.Size(121, 21);
            this.cboClassDay.TabIndex = 4;
            // 
            // dtpClassTIme
            // 
            this.dtpClassTIme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpClassTIme.Location = new System.Drawing.Point(525, 125);
            this.dtpClassTIme.Name = "dtpClassTIme";
            this.dtpClassTIme.Size = new System.Drawing.Size(77, 20);
            this.dtpClassTIme.TabIndex = 5;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(444, 58);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(75, 13);
            this.lblGroupName.TabIndex = 6;
            this.lblGroupName.Text = "Group\'s name:";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(444, 25);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(19, 13);
            this.lblGroupId.TabIndex = 8;
            this.lblGroupId.Text = "Id:";
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(478, 22);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.ReadOnly = true;
            this.txtGroupId.Size = new System.Drawing.Size(100, 20);
            this.txtGroupId.TabIndex = 7;
            // 
            // lblClassDay
            // 
            this.lblClassDay.AutoSize = true;
            this.lblClassDay.Location = new System.Drawing.Point(433, 93);
            this.lblClassDay.Name = "lblClassDay";
            this.lblClassDay.Size = new System.Drawing.Size(86, 13);
            this.lblClassDay.TabIndex = 9;
            this.lblClassDay.Text = "Day of the class:";
            // 
            // lblClassTime
            // 
            this.lblClassTime.AutoSize = true;
            this.lblClassTime.Location = new System.Drawing.Point(429, 125);
            this.lblClassTime.Name = "lblClassTime";
            this.lblClassTime.Size = new System.Drawing.Size(90, 13);
            this.lblClassTime.TabIndex = 10;
            this.lblClassTime.Text = "Time of the class:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(599, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(518, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(436, 179);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 13);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search by group\'s name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(12, 25);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(330, 20);
            this.txtSearchName.TabIndex = 16;
            this.txtSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyUp);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(433, 154);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(35, 13);
            this.lblBook.TabIndex = 19;
            this.lblBook.Text = "Book:";
            // 
            // cboBook
            // 
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(525, 151);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(121, 21);
            this.cboBook.TabIndex = 18;
            // 
            // FrmGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.cboBook);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblClassTime);
            this.Controls.Add(this.lblClassDay);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.dtpClassTIme);
            this.Controls.Add(this.cboClassDay);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.dgvGroups);
            this.Name = "FrmGroups";
            this.Text = "v";
            this.Enter += new System.EventHandler(this.FrmGroups_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.ComboBox cboClassDay;
        private System.Windows.Forms.DateTimePicker dtpClassTIme;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label lblClassDay;
        private System.Windows.Forms.Label lblClassTime;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.ComboBox cboBook;
    }
}