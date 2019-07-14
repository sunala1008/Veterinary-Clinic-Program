namespace Veterinary_Clinic.Winform
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.employeeControl = new Veterinary_Clinic.Winform.Controls.EmployeeControl();
            this.tabTreatment = new System.Windows.Forms.TabPage();
            this.treatmentControl = new Veterinary_Clinic.Winform.Controls.TreatmentControl();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.patientControl = new Veterinary_Clinic.Winform.Controls.PatientControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tsbPatient = new System.Windows.Forms.ToolStripButton();
            this.tsbTreat = new System.Windows.Forms.ToolStripButton();
            this.tsbAdmin = new System.Windows.Forms.ToolStripButton();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.lbMainWaitingList = new System.Windows.Forms.ListBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuzzer = new System.Windows.Forms.Button();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.lblMainCount = new System.Windows.Forms.Label();
            this.tabEmployee.SuspendLayout();
            this.tabTreatment.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.employeeControl);
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(807, 646);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = "직원";
            this.tabEmployee.ToolTipText = "직원 등록 & 조회";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // employeeControl
            // 
            this.employeeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeControl.Location = new System.Drawing.Point(3, 3);
            this.employeeControl.Name = "employeeControl";
            this.employeeControl.Size = new System.Drawing.Size(801, 640);
            this.employeeControl.TabIndex = 0;
            this.employeeControl.RegistButtonClicked += new System.EventHandler<Veterinary_Clinic.Winform.Controls.EmployeeControl.RegistButtonClickedEventArgs>(this.EmployeeControl_RegistButtonClicked);
            // 
            // tabTreatment
            // 
            this.tabTreatment.Controls.Add(this.treatmentControl);
            this.tabTreatment.Location = new System.Drawing.Point(4, 22);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreatment.Size = new System.Drawing.Size(807, 646);
            this.tabTreatment.TabIndex = 1;
            this.tabTreatment.Text = "진료";
            this.tabTreatment.ToolTipText = "진료";
            this.tabTreatment.UseVisualStyleBackColor = true;
            // 
            // treatmentControl
            // 
            this.treatmentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatmentControl.Location = new System.Drawing.Point(3, 3);
            this.treatmentControl.Name = "treatmentControl";
            this.treatmentControl.Size = new System.Drawing.Size(801, 640);
            this.treatmentControl.TabIndex = 0;
            this.treatmentControl.LbTreatmentWaitingList_DoubleClicked += new System.EventHandler<Veterinary_Clinic.Winform.Controls.TreatmentControl.LbTreatmentWaitingList_DoubleClickedEventArgs>(this.TreatmentControl_LbTreatmentWaitingList_DoubleClicked);
            this.treatmentControl.BtnNext_Clicked += new System.EventHandler<Veterinary_Clinic.Winform.Controls.TreatmentControl.BtnNext_ClickedEventArgs>(this.TreatmentControl_BtnNext_Clicked);
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.patientControl);
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(807, 646);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "환자";
            this.tabPatient.ToolTipText = "환자 등록과 조회를 하려면 이 탭을 누르세요.";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // patientControl
            // 
            this.patientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientControl.Location = new System.Drawing.Point(3, 3);
            this.patientControl.Name = "patientControl";
            this.patientControl.Size = new System.Drawing.Size(801, 640);
            this.patientControl.TabIndex = 0;
            this.patientControl.BtnSearch_Clicked += new System.EventHandler<Veterinary_Clinic.Winform.Controls.PatientControl.BtnSearch_ClickedEventArgs>(this.PatientControl_BtnSearch_Clicked);
            this.patientControl.BtnTreatmentRegist_Clicked += new System.EventHandler<Veterinary_Clinic.Winform.Controls.PatientControl.BtnTreatmentRegist_ClickedEventArgs>(this.PatientControl_BtnTreatmentRegist_Clicked);
            this.patientControl.Load += new System.EventHandler(this.MainForm_Load);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.webBrowser);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(807, 646);
            this.tabMain.TabIndex = 3;
            this.tabMain.Text = "메인";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(801, 640);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabMain);
            this.tabCtrl.Controls.Add(this.tabPatient);
            this.tabCtrl.Controls.Add(this.tabTreatment);
            this.tabCtrl.Controls.Add(this.tabEmployee);
            this.tabCtrl.Location = new System.Drawing.Point(194, 28);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(815, 672);
            this.tabCtrl.TabIndex = 7;
            // 
            // tsbPatient
            // 
            this.tsbPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPatient.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.tsbPatient.Image = global::Veterinary_Clinic.Winform.Properties.Resources.C_D;
            this.tsbPatient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPatient.Name = "tsbPatient";
            this.tsbPatient.Size = new System.Drawing.Size(181, 132);
            this.tsbPatient.Text = "tsbPatient";
            this.tsbPatient.ToolTipText = "환자 등록 & 조회";
            this.tsbPatient.Click += new System.EventHandler(this.TsbPatient_Click);
            // 
            // tsbTreat
            // 
            this.tsbTreat.AutoSize = false;
            this.tsbTreat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTreat.Image = global::Veterinary_Clinic.Winform.Properties.Resources.Doctor;
            this.tsbTreat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTreat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTreat.Name = "tsbTreat";
            this.tsbTreat.Size = new System.Drawing.Size(130, 132);
            this.tsbTreat.Text = "진료";
            this.tsbTreat.Click += new System.EventHandler(this.TsbTreat_Click);
            // 
            // tsbAdmin
            // 
            this.tsbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdmin.Image = global::Veterinary_Clinic.Winform.Properties.Resources.Veterinary;
            this.tsbAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdmin.Name = "tsbAdmin";
            this.tsbAdmin.Size = new System.Drawing.Size(181, 132);
            this.tsbAdmin.Text = "직원 메뉴";
            this.tsbAdmin.ToolTipText = "직원 등록 & 조회";
            this.tsbAdmin.Click += new System.EventHandler(this.TsbAdmin_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPatient,
            this.tsbTreat,
            this.tsbAdmin});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(183, 718);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "Menu";
            // 
            // lbMainWaitingList
            // 
            this.lbMainWaitingList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMainWaitingList.BackColor = System.Drawing.Color.Beige;
            this.lbMainWaitingList.FormattingEnabled = true;
            this.lbMainWaitingList.ItemHeight = 12;
            this.lbMainWaitingList.Location = new System.Drawing.Point(22, 465);
            this.lbMainWaitingList.Name = "lbMainWaitingList";
            this.lbMainWaitingList.Size = new System.Drawing.Size(76, 244);
            this.lbMainWaitingList.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(22, 414);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(148, 21);
            this.dateTimePicker.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(104, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 63);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnBuzzer
            // 
            this.btnBuzzer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuzzer.Image = ((System.Drawing.Image)(resources.GetObject("btnBuzzer.Image")));
            this.btnBuzzer.Location = new System.Drawing.Point(104, 465);
            this.btnBuzzer.Name = "btnBuzzer";
            this.btnBuzzer.Size = new System.Drawing.Size(66, 63);
            this.btnBuzzer.TabIndex = 13;
            this.btnBuzzer.UseVisualStyleBackColor = true;
            this.btnBuzzer.Click += new System.EventHandler(this.BtnBuzzer_Click);
            // 
            // BtnOFF
            // 
            this.BtnOFF.Image = global::Veterinary_Clinic.Winform.Properties.Resources.OFF;
            this.BtnOFF.Location = new System.Drawing.Point(104, 638);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(66, 67);
            this.BtnOFF.TabIndex = 9;
            this.BtnOFF.UseVisualStyleBackColor = true;
            this.BtnOFF.Click += new System.EventHandler(this.BtnOFF_Click);
            // 
            // lblMainCount
            // 
            this.lblMainCount.BackColor = System.Drawing.Color.Beige;
            this.lblMainCount.Location = new System.Drawing.Point(20, 439);
            this.lblMainCount.Name = "lblMainCount";
            this.lblMainCount.Size = new System.Drawing.Size(150, 23);
            this.lblMainCount.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 718);
            this.Controls.Add(this.lblMainCount);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.btnBuzzer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lbMainWaitingList);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabEmployee.ResumeLayout(false);
            this.tabTreatment.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabCtrl.ResumeLayout(false);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabTreatment;
        private Controls.TreatmentControl treatmentControl;
        private System.Windows.Forms.TabPage tabPatient;
        private Controls.PatientControl patientControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.ToolStripButton tsbPatient;
        private System.Windows.Forms.ToolStripButton tsbTreat;
        private System.Windows.Forms.ToolStripButton tsbAdmin;
        private System.Windows.Forms.ToolStrip tsMenu;
        public System.Windows.Forms.ListBox lbMainWaitingList;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuzzer;
        private System.Windows.Forms.Button BtnOFF;
        private System.Windows.Forms.Label lblMainCount;
        private Controls.EmployeeControl employeeControl;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}