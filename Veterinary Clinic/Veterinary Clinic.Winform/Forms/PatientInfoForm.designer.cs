namespace Veterinary_Clinic.Winform.Forms
{
    partial class PatientInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCompanionName = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbPhoneNum = new System.Windows.Forms.TextBox();
            this.cbbSpeciesId = new System.Windows.Forms.ComboBox();
            this.bdsSpecies = new System.Windows.Forms.BindingSource(this.components);
            this.cbbBreedsId = new System.Windows.Forms.ComboBox();
            this.bdsBreeds = new System.Windows.Forms.BindingSource(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUndone = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBreeds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "품종 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "생일 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "보호자 이름 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "몸무게 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "전화번호 : ";
            // 
            // txbCompanionName
            // 
            this.txbCompanionName.Location = new System.Drawing.Point(104, 121);
            this.txbCompanionName.Name = "txbCompanionName";
            this.txbCompanionName.Size = new System.Drawing.Size(120, 21);
            this.txbCompanionName.TabIndex = 18;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(103, 13);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(120, 21);
            this.txbName.TabIndex = 3;
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "yyyy-MM-dd";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(103, 66);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(120, 21);
            this.dtpBirth.TabIndex = 8;
            this.dtpBirth.Value = new System.DateTime(2019, 6, 24, 0, 0, 0, 0);
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(103, 94);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(120, 21);
            this.txbWeight.TabIndex = 15;
            // 
            // txbPhoneNum
            // 
            this.txbPhoneNum.Location = new System.Drawing.Point(103, 148);
            this.txbPhoneNum.Name = "txbPhoneNum";
            this.txbPhoneNum.Size = new System.Drawing.Size(120, 21);
            this.txbPhoneNum.TabIndex = 20;
            // 
            // cbbSpeciesId
            // 
            this.cbbSpeciesId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsSpecies, "SpeciesID", true));
            this.cbbSpeciesId.DataSource = this.bdsSpecies;
            this.cbbSpeciesId.DisplayMember = "Name";
            this.cbbSpeciesId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSpeciesId.FormattingEnabled = true;
            this.cbbSpeciesId.Location = new System.Drawing.Point(103, 40);
            this.cbbSpeciesId.Name = "cbbSpeciesId";
            this.cbbSpeciesId.Size = new System.Drawing.Size(121, 20);
            this.cbbSpeciesId.TabIndex = 5;
            this.cbbSpeciesId.ValueMember = "SpeciesID";
            this.cbbSpeciesId.SelectedValueChanged += new System.EventHandler(this.CbbSpeciesId_SelectedValueChanged);
            // 
            // bdsSpecies
            // 
            this.bdsSpecies.DataSource = typeof(Veterinary_Clinic.Library.Species);
            // 
            // cbbBreedsId
            // 
            this.cbbBreedsId.DataSource = this.bdsBreeds;
            this.cbbBreedsId.DisplayMember = "Name";
            this.cbbBreedsId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBreedsId.FormattingEnabled = true;
            this.cbbBreedsId.Location = new System.Drawing.Point(230, 40);
            this.cbbBreedsId.Name = "cbbBreedsId";
            this.cbbBreedsId.Size = new System.Drawing.Size(121, 20);
            this.cbbBreedsId.TabIndex = 6;
            this.cbbBreedsId.ValueMember = "BreedsID";
            // 
            // bdsBreeds
            // 
            this.bdsBreeds.DataSource = typeof(Veterinary_Clinic.Library.Breeds);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(246, 191);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(50, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "등록";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // btnUndone
            // 
            this.btnUndone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndone.Location = new System.Drawing.Point(302, 191);
            this.btnUndone.Name = "btnUndone";
            this.btnUndone.Size = new System.Drawing.Size(50, 23);
            this.btnUndone.TabIndex = 1;
            this.btnUndone.Text = "취소";
            this.btnUndone.UseVisualStyleBackColor = true;
            this.btnUndone.Click += new System.EventHandler(this.BtnUndone_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "kg";
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifier.Location = new System.Drawing.Point(246, 191);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(50, 23);
            this.btnModifier.TabIndex = 21;
            this.btnModifier.Text = "수정";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(359, 225);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUndone);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cbbBreedsId);
            this.Controls.Add(this.cbbSpeciesId);
            this.Controls.Add(this.txbPhoneNum);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbCompanionName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientInfoForm";
            this.Text = "Regist";
            this.Load += new System.EventHandler(this.PatientBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBreeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCompanionName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbPhoneNum;
        private System.Windows.Forms.ComboBox cbbSpeciesId;
        private System.Windows.Forms.ComboBox cbbBreedsId;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnUndone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.BindingSource bdsSpecies;
        private System.Windows.Forms.BindingSource bdsBreeds;
    }
}