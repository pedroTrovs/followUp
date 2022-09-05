namespace followUp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblGroupId;
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblDgvStudents = new System.Windows.Forms.Label();
            this.txtStudId = new System.Windows.Forms.TextBox();
            this.lblStudId = new System.Windows.Forms.Label();
            this.lblStudName = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.lblAssignedGroup = new System.Windows.Forms.Label();
            this.txtAssignedGroup = new System.Windows.Forms.TextBox();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            lblGroupId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroupId
            // 
            lblGroupId.AutoSize = true;
            lblGroupId.Location = new System.Drawing.Point(587, 115);
            lblGroupId.Name = "lblGroupId";
            lblGroupId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblGroupId.Size = new System.Drawing.Size(51, 13);
            lblGroupId.TabIndex = 9;
            lblGroupId.Text = "Group Id:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(37, 67);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(293, 311);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellDoubleClick);
            // 
            // lblDgvStudents
            // 
            this.lblDgvStudents.AutoSize = true;
            this.lblDgvStudents.Location = new System.Drawing.Point(34, 20);
            this.lblDgvStudents.Name = "lblDgvStudents";
            this.lblDgvStudents.Size = new System.Drawing.Size(52, 13);
            this.lblDgvStudents.TabIndex = 1;
            this.lblDgvStudents.Text = "Students:";
            // 
            // txtStudId
            // 
            this.txtStudId.Location = new System.Drawing.Point(395, 45);
            this.txtStudId.Name = "txtStudId";
            this.txtStudId.ReadOnly = true;
            this.txtStudId.Size = new System.Drawing.Size(70, 20);
            this.txtStudId.TabIndex = 2;
            // 
            // lblStudId
            // 
            this.lblStudId.AutoSize = true;
            this.lblStudId.Location = new System.Drawing.Point(370, 48);
            this.lblStudId.Name = "lblStudId";
            this.lblStudId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStudId.Size = new System.Drawing.Size(19, 13);
            this.lblStudId.TabIndex = 3;
            this.lblStudId.Text = "Id:";
            // 
            // lblStudName
            // 
            this.lblStudName.AutoSize = true;
            this.lblStudName.Location = new System.Drawing.Point(371, 86);
            this.lblStudName.Name = "lblStudName";
            this.lblStudName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStudName.Size = new System.Drawing.Size(55, 13);
            this.lblStudName.TabIndex = 5;
            this.lblStudName.Text = "Full name:";
            // 
            // txtStudName
            // 
            this.txtStudName.Location = new System.Drawing.Point(432, 83);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(282, 20);
            this.txtStudName.TabIndex = 4;
            // 
            // lblAssignedGroup
            // 
            this.lblAssignedGroup.AutoSize = true;
            this.lblAssignedGroup.Location = new System.Drawing.Point(371, 115);
            this.lblAssignedGroup.Name = "lblAssignedGroup";
            this.lblAssignedGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAssignedGroup.Size = new System.Drawing.Size(83, 13);
            this.lblAssignedGroup.TabIndex = 6;
            this.lblAssignedGroup.Text = "Assigned group:";
            // 
            // txtAssignedGroup
            // 
            this.txtAssignedGroup.Location = new System.Drawing.Point(455, 112);
            this.txtAssignedGroup.Name = "txtAssignedGroup";
            this.txtAssignedGroup.ReadOnly = true;
            this.txtAssignedGroup.Size = new System.Drawing.Size(119, 20);
            this.txtAssignedGroup.TabIndex = 7;
            this.txtAssignedGroup.Click += new System.EventHandler(this.txtAssignedGroup_Click);
            this.txtAssignedGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssignedGroup_KeyPress);
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(644, 112);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.ReadOnly = true;
            this.txtGroupId.Size = new System.Drawing.Size(70, 20);
            this.txtGroupId.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(373, 153);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(455, 153);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(536, 153);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(129, 41);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(201, 20);
            this.txtSearchName.TabIndex = 13;
            this.txtSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchName_KeyUp);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(126, 20);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(87, 13);
            this.lblSearchName.TabIndex = 14;
            this.lblSearchName.Text = "Search by name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(lblGroupId);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.txtAssignedGroup);
            this.Controls.Add(this.lblAssignedGroup);
            this.Controls.Add(this.lblStudName);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.lblStudId);
            this.Controls.Add(this.txtStudId);
            this.Controls.Add(this.lblDgvStudents);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblDgvStudents;
        private System.Windows.Forms.TextBox txtStudId;
        private System.Windows.Forms.Label lblStudId;
        private System.Windows.Forms.Label lblStudName;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label lblAssignedGroup;
        private System.Windows.Forms.TextBox txtAssignedGroup;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Button button2;
    }
}

