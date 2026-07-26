namespace ClinicManagement
{
    partial class FrmDoctorsList
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
            this.dvgDoctor = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateSpecialty = new System.Windows.Forms.TextBox();
            this.txtUpdateMedicalCouncilNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDoctor
            // 
            this.dvgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDoctor.Location = new System.Drawing.Point(29, 116);
            this.dvgDoctor.Name = "dvgDoctor";
            this.dvgDoctor.RowHeadersWidth = 51;
            this.dvgDoctor.RowTemplate.Height = 24;
            this.dvgDoctor.Size = new System.Drawing.Size(683, 253);
            this.dvgDoctor.TabIndex = 0;
            this.dvgDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDoctor_CellContentClick);
            this.dvgDoctor.SelectionChanged += new System.EventHandler(this.dvgDoctor_SelectionChanged);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(273, 44);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(248, 28);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete with by MedicalCouncilNumber";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(531, 47);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(100, 22);
            this.textBoxDelete.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(61, 49);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 26);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(73, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 26);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // txtUpdateSpecialty
            // 
            this.txtUpdateSpecialty.Location = new System.Drawing.Point(189, 413);
            this.txtUpdateSpecialty.Name = "txtUpdateSpecialty";
            this.txtUpdateSpecialty.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateSpecialty.TabIndex = 2;
            // 
            // txtUpdateMedicalCouncilNumber
            // 
            this.txtUpdateMedicalCouncilNumber.Location = new System.Drawing.Point(305, 413);
            this.txtUpdateMedicalCouncilNumber.Name = "txtUpdateMedicalCouncilNumber";
            this.txtUpdateMedicalCouncilNumber.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateMedicalCouncilNumber.TabIndex = 2;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(421, 413);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateLastName.TabIndex = 2;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(527, 413);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtUpdateFirstName.TabIndex = 2;
            // 
            // FrmDoctorsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 485);
            this.Controls.Add(this.txtUpdateFirstName);
            this.Controls.Add(this.txtUpdateLastName);
            this.Controls.Add(this.txtUpdateMedicalCouncilNumber);
            this.Controls.Add(this.txtUpdateSpecialty);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dvgDoctor);
            this.Name = "FrmDoctorsList";
            this.Text = "FrmDoctorsList";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDoctor;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateSpecialty;
        private System.Windows.Forms.TextBox txtUpdateMedicalCouncilNumber;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
    }
}