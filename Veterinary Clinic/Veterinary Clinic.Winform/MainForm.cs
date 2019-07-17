using System;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Data;
using Veterinary_Clinic.Library.Helpers;
using Veterinary_Clinic.Winform.Controls;
using Veterinary_Clinic.Winform.Forms;

namespace Veterinary_Clinic.Winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowWaitingListCount();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode)
                return;
        }

        #region Main Method
        // 대기자 목록의 인원 수
        private void ShowWaitingListCount() 
        {
            lblMainCount.Text = $"현재 대기자 : 총 {lbMainWaitingList.Items.Count}명";
        }

        public TreatmentControl TreatmentControl
        {
            get
            {
                return treatmentControl;
            }
        }
        #endregion

        #region MainForm Event       
        private void MainForm_Load(object sender, EventArgs e)
        {
            patientControl.LoadSpecies();
            treatmentControl.LoadDisease();
            treatmentControl.LoadDrug();
            treatmentControl.LoadOperation();
        }

        // 프로그램 종료 버튼
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 탭버튼과 아이콘 버튼 연동
        private void TsbPatient_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tabPatient;
        }
        private void TsbTreat_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tabTreatment;
        }
        private void TsbAdmin_Click(object sender, EventArgs e)
        {
            tabCtrl.SelectedTab = tabEmployee;
        }

        // 대기자 삭제
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            lbMainWaitingList.Items.Remove(lbMainWaitingList.SelectedItem);
            ShowWaitingListCount();
        }

        // 대기자 호출
        private void BtnBuzzer_Click(object sender, EventArgs e)
        {
            if (lbMainWaitingList.Items.Count == 0)
                return;

            if (lbMainWaitingList.SelectedItem == null)
                return;

            string call = lbMainWaitingList.SelectedItem.ToString();
            string[] splits = call.Split('\t');

            MessageBox.Show($"{splits[0]}의 차례입니다.");
            tabCtrl.SelectedTab = tabTreatment;
        }
        #endregion

        #region PatientControls Event
        private void PatientControl_BtnSearch_Clicked(object sender, PatientControl.BtnSearch_ClickedEventArgs e)
        {
            var patient = DB.Patient.Search(e.PhoneNum, e.PetName, e.SpeciesId);

            patientControl.SetPatientDataSource(patient);
        }        
        private void PatientControl_BtnTreatmentRegist_Clicked(object sender, PatientControl.BtnTreatmentRegist_ClickedEventArgs e)
        {
            if (!(patientControl.CurrnetRowDataBoundItem is Patient patient))
                return;
            
            Form form = new TreatmentRegistForm(patient);
            FormHelper.MoveToCenter(form);
            form.Owner = this;
            form.ShowDialog();
            ShowWaitingListCount();
        }
        #endregion

        #region TreatmentControls Event
        private void TreatmentControl_LbTreatmentWaitingList_DoubleClicked(object sender, TreatmentControl.LbTreatmentWaitingList_DoubleClickedEventArgs e)
        {
            if (lbMainWaitingList.Items.Count != 0)
                lbMainWaitingList.SelectedIndex = 0;
            else
                return;

            btnDelete.PerformClick();

            Patient patient = DB.Patient.SearchFromTreatementControl((string)treatmentControl.TreatmentWaitingList.SelectedItem);

            treatmentControl.ShowPatientInfo(patient);
        }
        private void TreatmentControl_BtnNext_Clicked(object sender, TreatmentControl.BtnNext_ClickedEventArgs e)
        {
            lbMainWaitingList.SelectedIndex = 0;
            btnDelete.PerformClick();
        }
        #endregion

        #region EmployeeControls Event
        private void EmployeeControl_RegistButtonClicked(object sender, EmployeeControl.RegistButtonClickedEventArgs e)
        {
            var employee = DB.Employee.Search(e.Name, e.Num);
            employeeControl.SetEmployeeData(employee);
        }
        #endregion
    }
}
