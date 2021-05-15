
namespace BT03_102190100_NguyenDoVuong.View
{
     partial class Form7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbChonlop = new System.Windows.Forms.ComboBox();
            this.txtNameSV = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.LopSH = new System.Windows.Forms.Label();
            this.NameSV = new System.Windows.Forms.Label();
            this.MSSV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btOK);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbbChonlop);
            this.groupBox1.Controls.Add(this.txtNameSV);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.LopSH);
            this.groupBox1.Controls.Add(this.NameSV);
            this.groupBox1.Controls.Add(this.MSSV);
            this.groupBox1.Location = new System.Drawing.Point(39, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin SV";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(386, 230);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(110, 47);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(125, 230);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(110, 47);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdFemale);
            this.groupBox2.Controls.Add(this.rdMale);
            this.groupBox2.Location = new System.Drawing.Point(297, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(124, 42);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(75, 21);
            this.rdFemale.TabIndex = 0;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(19, 42);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(59, 21);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cbbChonlop
            // 
            this.cbbChonlop.FormattingEnabled = true;
            this.cbbChonlop.Location = new System.Drawing.Point(103, 128);
            this.cbbChonlop.Name = "cbbChonlop";
            this.cbbChonlop.Size = new System.Drawing.Size(149, 24);
            this.cbbChonlop.TabIndex = 2;
            // 
            // txtNameSV
            // 
            this.txtNameSV.Location = new System.Drawing.Point(103, 89);
            this.txtNameSV.Multiline = true;
            this.txtNameSV.Name = "txtNameSV";
            this.txtNameSV.Size = new System.Drawing.Size(150, 29);
            this.txtNameSV.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(103, 53);
            this.txtMSSV.Multiline = true;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 30);
            this.txtMSSV.TabIndex = 1;
            // 
            // LopSH
            // 
            this.LopSH.AutoSize = true;
            this.LopSH.Location = new System.Drawing.Point(51, 132);
            this.LopSH.Name = "LopSH";
            this.LopSH.Size = new System.Drawing.Size(51, 17);
            this.LopSH.TabIndex = 0;
            this.LopSH.Text = "LopSH";
            // 
            // NameSV
            // 
            this.NameSV.AutoSize = true;
            this.NameSV.Location = new System.Drawing.Point(51, 92);
            this.NameSV.Name = "NameSV";
            this.NameSV.Size = new System.Drawing.Size(45, 17);
            this.NameSV.TabIndex = 0;
            this.NameSV.Text = "Name";
            // 
            // MSSV
            // 
            this.MSSV.AutoSize = true;
            this.MSSV.Location = new System.Drawing.Point(51, 56);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(46, 17);
            this.MSSV.TabIndex = 0;
            this.MSSV.Text = "MSSV";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 372);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LopSH;
        private System.Windows.Forms.Label NameSV;
        private System.Windows.Forms.Label MSSV;
        private System.Windows.Forms.TextBox txtNameSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cbbChonlop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
    }
}