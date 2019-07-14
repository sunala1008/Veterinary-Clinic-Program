namespace Veterinary_Clinic.Winform.Controls
{
    partial class TreatmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitCtr1 = new System.Windows.Forms.SplitContainer();
            this.splitCtr2 = new System.Windows.Forms.SplitContainer();
            this.txbBirth = new System.Windows.Forms.TextBox();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbGender = new System.Windows.Forms.TextBox();
            this.txbPetName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTreatmentWaitingList = new System.Windows.Forms.ListBox();
            this.lblWaitingCount = new System.Windows.Forms.Label();
            this.splitCtr3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bdsPrescription = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOperation = new System.Windows.Forms.CheckBox();
            this.cbxInHospital = new System.Windows.Forms.CheckBox();
            this.cbbDrug = new System.Windows.Forms.ComboBox();
            this.bdsDrug = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbbDisease = new System.Windows.Forms.ComboBox();
            this.bdsDisease = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbbOperation = new System.Windows.Forms.ComboBox();
            this.bdsOperation = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnTreatComplete = new System.Windows.Forms.Button();
            this.rxbInscription = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inHospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outHospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr1)).BeginInit();
            this.splitCtr1.Panel1.SuspendLayout();
            this.splitCtr1.Panel2.SuspendLayout();
            this.splitCtr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr2)).BeginInit();
            this.splitCtr2.Panel1.SuspendLayout();
            this.splitCtr2.Panel2.SuspendLayout();
            this.splitCtr2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr3)).BeginInit();
            this.splitCtr3.Panel1.SuspendLayout();
            this.splitCtr3.Panel2.SuspendLayout();
            this.splitCtr3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDisease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCtr1
            // 
            this.splitCtr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtr1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCtr1.Location = new System.Drawing.Point(0, 0);
            this.splitCtr1.Name = "splitCtr1";
            // 
            // splitCtr1.Panel1
            // 
            this.splitCtr1.Panel1.Controls.Add(this.splitCtr2);
            // 
            // splitCtr1.Panel2
            // 
            this.splitCtr1.Panel2.Controls.Add(this.splitCtr3);
            this.splitCtr1.Size = new System.Drawing.Size(524, 410);
            this.splitCtr1.SplitterDistance = 180;
            this.splitCtr1.TabIndex = 0;
            // 
            // splitCtr2
            // 
            this.splitCtr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtr2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitCtr2.Location = new System.Drawing.Point(0, 0);
            this.splitCtr2.Name = "splitCtr2";
            this.splitCtr2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCtr2.Panel1
            // 
            this.splitCtr2.Panel1.Controls.Add(this.txbBirth);
            this.splitCtr2.Panel1.Controls.Add(this.txbWeight);
            this.splitCtr2.Panel1.Controls.Add(this.txbGender);
            this.splitCtr2.Panel1.Controls.Add(this.txbPetName);
            this.splitCtr2.Panel1.Controls.Add(this.label5);
            this.splitCtr2.Panel1.Controls.Add(this.label4);
            this.splitCtr2.Panel1.Controls.Add(this.label3);
            this.splitCtr2.Panel1.Controls.Add(this.label2);
            // 
            // splitCtr2.Panel2
            // 
            this.splitCtr2.Panel2.Controls.Add(this.lbTreatmentWaitingList);
            this.splitCtr2.Panel2.Controls.Add(this.lblWaitingCount);
            this.splitCtr2.Size = new System.Drawing.Size(180, 410);
            this.splitCtr2.SplitterDistance = 181;
            this.splitCtr2.TabIndex = 0;
            // 
            // txbBirth
            // 
            this.txbBirth.Location = new System.Drawing.Point(70, 143);
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.Size = new System.Drawing.Size(100, 21);
            this.txbBirth.TabIndex = 7;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(70, 102);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(100, 21);
            this.txbWeight.TabIndex = 6;
            // 
            // txbGender
            // 
            this.txbGender.Location = new System.Drawing.Point(70, 60);
            this.txbGender.Name = "txbGender";
            this.txbGender.Size = new System.Drawing.Size(100, 21);
            this.txbGender.TabIndex = 5;
            // 
            // txbPetName
            // 
            this.txbPetName.Location = new System.Drawing.Point(70, 23);
            this.txbPetName.Name = "txbPetName";
            this.txbPetName.Size = new System.Drawing.Size(100, 21);
            this.txbPetName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "출생일 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "체중 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "성별 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "이름 : ";
            // 
            // lbTreatmentWaitingList
            // 
            this.lbTreatmentWaitingList.BackColor = System.Drawing.Color.Beige;
            this.lbTreatmentWaitingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTreatmentWaitingList.FormattingEnabled = true;
            this.lbTreatmentWaitingList.ItemHeight = 12;
            this.lbTreatmentWaitingList.Location = new System.Drawing.Point(0, 22);
            this.lbTreatmentWaitingList.Name = "lbTreatmentWaitingList";
            this.lbTreatmentWaitingList.Size = new System.Drawing.Size(180, 203);
            this.lbTreatmentWaitingList.TabIndex = 0;
            this.lbTreatmentWaitingList.DoubleClick += new System.EventHandler(this.LbTreatmentWaitingList_DoubleClick);
            // 
            // lblWaitingCount
            // 
            this.lblWaitingCount.BackColor = System.Drawing.Color.Beige;
            this.lblWaitingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaitingCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaitingCount.Location = new System.Drawing.Point(0, 0);
            this.lblWaitingCount.Name = "lblWaitingCount";
            this.lblWaitingCount.Size = new System.Drawing.Size(180, 22);
            this.lblWaitingCount.TabIndex = 1;
            this.lblWaitingCount.Text = "대기자 명단";
            this.lblWaitingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaitingCount.TextChanged += new System.EventHandler(this.LbWaitingCount_TextChanged);
            // 
            // splitCtr3
            // 
            this.splitCtr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCtr3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitCtr3.Location = new System.Drawing.Point(0, 0);
            this.splitCtr3.Name = "splitCtr3";
            this.splitCtr3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCtr3.Panel1
            // 
            this.splitCtr3.Panel1.Controls.Add(this.dataGridView);
            this.splitCtr3.Panel1.Controls.Add(this.label1);
            this.splitCtr3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitCtr3.Panel2
            // 
            this.splitCtr3.Panel2.Controls.Add(this.btnNext);
            this.splitCtr3.Panel2.Controls.Add(this.btnTreatComplete);
            this.splitCtr3.Panel2.Controls.Add(this.rxbInscription);
            this.splitCtr3.Size = new System.Drawing.Size(340, 410);
            this.splitCtr3.SplitterDistance = 253;
            this.splitCtr3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxOperation);
            this.groupBox1.Controls.Add(this.cbxInHospital);
            this.groupBox1.Controls.Add(this.cbbDrug);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbDisease);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbbOperation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bdsPrescription
            // 
            this.bdsPrescription.DataSource = typeof(Veterinary_Clinic.Library.Prescription);
            // 
            // cbxOperation
            // 
            this.cbxOperation.AutoSize = true;
            this.cbxOperation.Location = new System.Drawing.Point(88, 68);
            this.cbxOperation.Name = "cbxOperation";
            this.cbxOperation.Size = new System.Drawing.Size(15, 14);
            this.cbxOperation.TabIndex = 10;
            this.cbxOperation.UseVisualStyleBackColor = true;
            this.cbxOperation.CheckedChanged += new System.EventHandler(this.CbxOperation_CheckedChanged);
            // 
            // cbxInHospital
            // 
            this.cbxInHospital.AutoSize = true;
            this.cbxInHospital.Location = new System.Drawing.Point(88, 32);
            this.cbxInHospital.Name = "cbxInHospital";
            this.cbxInHospital.Size = new System.Drawing.Size(15, 14);
            this.cbxInHospital.TabIndex = 9;
            this.cbxInHospital.UseVisualStyleBackColor = true;
            // 
            // cbbDrug
            // 
            this.cbbDrug.DataSource = this.bdsDrug;
            this.cbbDrug.DisplayMember = "Name";
            this.cbbDrug.FormattingEnabled = true;
            this.cbbDrug.Location = new System.Drawing.Point(88, 133);
            this.cbbDrug.Name = "cbbDrug";
            this.cbbDrug.Size = new System.Drawing.Size(121, 20);
            this.cbbDrug.TabIndex = 8;
            this.cbbDrug.ValueMember = "DrugID";
            // 
            // bdsDrug
            // 
            this.bdsDrug.DataSource = typeof(Veterinary_Clinic.Library.Drug);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "약 :";
            // 
            // cbbDisease
            // 
            this.cbbDisease.DataSource = this.bdsDisease;
            this.cbbDisease.DisplayMember = "Name";
            this.cbbDisease.FormattingEnabled = true;
            this.cbbDisease.Location = new System.Drawing.Point(88, 98);
            this.cbbDisease.Name = "cbbDisease";
            this.cbbDisease.Size = new System.Drawing.Size(121, 20);
            this.cbbDisease.TabIndex = 6;
            this.cbbDisease.ValueMember = "DiseaseID";
            // 
            // bdsDisease
            // 
            this.bdsDisease.DataSource = typeof(Veterinary_Clinic.Library.Disease);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "병명 :";
            // 
            // cbbOperation
            // 
            this.cbbOperation.DataSource = this.bdsOperation;
            this.cbbOperation.DisplayMember = "Name";
            this.cbbOperation.Enabled = false;
            this.cbbOperation.FormattingEnabled = true;
            this.cbbOperation.Location = new System.Drawing.Point(118, 65);
            this.cbbOperation.Name = "cbbOperation";
            this.cbbOperation.Size = new System.Drawing.Size(121, 20);
            this.cbbOperation.TabIndex = 4;
            this.cbbOperation.ValueMember = "OperationID";
            // 
            // bdsOperation
            // 
            this.bdsOperation.DataSource = typeof(Veterinary_Clinic.Library.Operation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "수술여부 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "입원여부 :";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(181, 116);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 34);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnTreatComplete
            // 
            this.btnTreatComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTreatComplete.Location = new System.Drawing.Point(262, 116);
            this.btnTreatComplete.Name = "btnTreatComplete";
            this.btnTreatComplete.Size = new System.Drawing.Size(75, 34);
            this.btnTreatComplete.TabIndex = 2;
            this.btnTreatComplete.Text = "진료 완료";
            this.btnTreatComplete.UseVisualStyleBackColor = true;
            this.btnTreatComplete.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // rxbInscription
            // 
            this.rxbInscription.Dock = System.Windows.Forms.DockStyle.Top;
            this.rxbInscription.Location = new System.Drawing.Point(0, 0);
            this.rxbInscription.Name = "rxbInscription";
            this.rxbInscription.Size = new System.Drawing.Size(340, 110);
            this.rxbInscription.TabIndex = 1;
            this.rxbInscription.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscriptionDataGridViewTextBoxColumn,
            this.inHospitalDataGridViewTextBoxColumn,
            this.outHospitalDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bdsPrescription;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 183);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(340, 70);
            this.dataGridView.TabIndex = 13;
            // 
            // inscriptionDataGridViewTextBoxColumn
            // 
            this.inscriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inscriptionDataGridViewTextBoxColumn.DataPropertyName = "Inscription";
            this.inscriptionDataGridViewTextBoxColumn.HeaderText = "Inscription";
            this.inscriptionDataGridViewTextBoxColumn.Name = "inscriptionDataGridViewTextBoxColumn";
            this.inscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inHospitalDataGridViewTextBoxColumn
            // 
            this.inHospitalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.inHospitalDataGridViewTextBoxColumn.DataPropertyName = "InHospital";
            this.inHospitalDataGridViewTextBoxColumn.HeaderText = "InHospital";
            this.inHospitalDataGridViewTextBoxColumn.Name = "inHospitalDataGridViewTextBoxColumn";
            this.inHospitalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outHospitalDataGridViewTextBoxColumn
            // 
            this.outHospitalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.outHospitalDataGridViewTextBoxColumn.DataPropertyName = "OutHospital";
            this.outHospitalDataGridViewTextBoxColumn.HeaderText = "OutHospital";
            this.outHospitalDataGridViewTextBoxColumn.Name = "outHospitalDataGridViewTextBoxColumn";
            this.outHospitalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "진료기록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TreatmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitCtr1);
            this.Name = "TreatmentControl";
            this.Size = new System.Drawing.Size(524, 410);
            this.splitCtr1.Panel1.ResumeLayout(false);
            this.splitCtr1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr1)).EndInit();
            this.splitCtr1.ResumeLayout(false);
            this.splitCtr2.Panel1.ResumeLayout(false);
            this.splitCtr2.Panel1.PerformLayout();
            this.splitCtr2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr2)).EndInit();
            this.splitCtr2.ResumeLayout(false);
            this.splitCtr3.Panel1.ResumeLayout(false);
            this.splitCtr3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCtr3)).EndInit();
            this.splitCtr3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDisease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCtr1;
        private System.Windows.Forms.SplitContainer splitCtr2;
        private System.Windows.Forms.ListBox lbTreatmentWaitingList;
        private System.Windows.Forms.Label lblWaitingCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitCtr3;
        private System.Windows.Forms.RichTextBox rxbInscription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbBirth;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbGender;
        private System.Windows.Forms.TextBox txbPetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbOperation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbDisease;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbDrug;
        private System.Windows.Forms.CheckBox cbxOperation;
        private System.Windows.Forms.CheckBox cbxInHospital;
        private System.Windows.Forms.BindingSource bdsOperation;
        private System.Windows.Forms.BindingSource bdsDrug;
        private System.Windows.Forms.BindingSource bdsDisease;
        private System.Windows.Forms.Button btnTreatComplete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.BindingSource bdsPrescription;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inHospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outHospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
