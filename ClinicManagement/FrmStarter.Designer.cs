namespace ClinicManagement
{
    partial class FrmStarter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.customButton1 = new ClinicManagement.CustomButton();
            this.customTextBox1 = new ClinicManagement.CustomTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "بیماران";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "دکتر ها";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(494, 59);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(102, 23);
            this.customButton1.TabIndex = 4;
            this.customButton1.Text = "customButton1";
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // customTextBox1
            // 
            this.customTextBox1.Location = new System.Drawing.Point(189, 151);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.PlaceHolderText = "";
            this.customTextBox1.ShowPlaceHolder = false;
            this.customTextBox1.Size = new System.Drawing.Size(100, 22);
            this.customTextBox1.TabIndex = 5;
            // 
            // FrmStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 206);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStarter";
            this.Text = "FrmStarter";
            this.Load += new System.EventHandler(this.FrmStarter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private CustomButton customButton1;
        private CustomTextBox customTextBox1;
    }
}