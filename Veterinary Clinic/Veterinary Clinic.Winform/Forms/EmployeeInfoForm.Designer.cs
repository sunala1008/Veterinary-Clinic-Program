namespace Veterinary_Clinic.Winform.Forms
{
    partial class EmployeeInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInfoForm));
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnUndone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFireDate = new System.Windows.Forms.DateTimePicker();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.cbxFireDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(105, 15);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(120, 21);
            this.txbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름 : ";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(133, 190);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(50, 23);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "등록";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(133, 190);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(50, 23);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "수정";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnUndone
            // 
            this.btnUndone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndone.Location = new System.Drawing.Point(189, 190);
            this.btnUndone.Name = "btnUndone";
            this.btnUndone.Size = new System.Drawing.Size(50, 23);
            this.btnUndone.TabIndex = 22;
            this.btnUndone.Text = "취소";
            this.btnUndone.UseVisualStyleBackColor = true;
            this.btnUndone.Click += new System.EventHandler(this.BtnUndone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "생일 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "메일주소 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "전화번호 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "퇴사일 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "고용일 : ";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(105, 42);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(120, 21);
            this.dtpBirth.TabIndex = 29;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CustomFormat = "yyyy-MM-dd";
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDate.Location = new System.Drawing.Point(105, 120);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(120, 21);
            this.dtpHireDate.TabIndex = 30;
            // 
            // dtpFireDate
            // 
            this.dtpFireDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFireDate.Enabled = false;
            this.dtpFireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFireDate.Location = new System.Drawing.Point(105, 147);
            this.dtpFireDate.Name = "dtpFireDate";
            this.dtpFireDate.Size = new System.Drawing.Size(120, 21);
            this.dtpFireDate.TabIndex = 31;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(105, 69);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(120, 21);
            this.txbPhoneNum.TabIndex = 32;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(105, 97);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(120, 21);
            this.txbMail.TabIndex = 33;
            // 
            // cbxFireDate
            // 
            this.cbxFireDate.AutoSize = true;
            this.cbxFireDate.Location = new System.Drawing.Point(84, 153);
            this.cbxFireDate.Name = "cbxFireDate";
            this.cbxFireDate.Size = new System.Drawing.Size(15, 14);
            this.cbxFireDate.TabIndex = 34;
            this.cbxFireDate.UseVisualStyleBackColor = true;
            this.cbxFireDate.CheckedChanged += new System.EventHandler(this.CbxFireDate_CheckedChanged);
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 225);
            this.Controls.Add(this.cbxFireDate);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbPhoneNum);
            this.Controls.Add(this.dtpFireDate);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnUndone);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeInfoForm";
            this.Text = "Regist";
            this.Load += new System.EventHandler(this.EmployeeInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnUndone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpFireDate;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.CheckBox cbxFireDate;
    }
}