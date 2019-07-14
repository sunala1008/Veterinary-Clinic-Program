using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Data;

namespace Veterinary_Clinic.Winform.Controls
{
    public partial class TreatmentControl : UserControl
    {
        public Patient Patient { get; private set; }

        public TreatmentControl()
        {
            InitializeComponent();
        }

        #region Method
        public void ShowPatientInfo(Patient patient)
        {
            Patient = patient;
            ReadFromEntity();
        }
        public void LoadOperation()
        {
            bdsOperation.DataSource = DB.Operation.GetAll();
        }
        public void LoadDisease()
        {
            bdsDisease.DataSource = DB.Disease.GetAll();
        }
        public void LoadDrug()
        {
            bdsDrug.DataSource = DB.Drug.GetAll();
        }
        public void LoadPrescription()
        {
            int patientId = Patient.PatientID;
            bdsPrescription.DataSource = DB.Prescription.GetRecord(patientId);
        }

        private void ReadFromEntity()
        {
            txbPetName.Text = Patient.Name;
            txbBirth.Text = Patient.Birth.ToString("yyyy/MM/dd");
            txbWeight.Text = Patient.Weight.ToString();

            if (Patient.IsFeMale == false)
                txbGender.Text = "수컷";
            else if (Patient.IsFeMale == true)
                txbGender.Text = "암컷";
            else
                txbGender.Text = "중성";
        }
        public ListBox TreatmentWaitingList
        {
            get
            {
                return lbTreatmentWaitingList;
            }
        }
        #endregion

        #region Event
        private void LbWaitingCount_TextChanged(object sender, EventArgs e)
        {
            lblWaitingCount.Text = $"대기자 명단 : 총 {lbTreatmentWaitingList.Items.Count}명";
        }
        private void CbxOperation_CheckedChanged(object sender, EventArgs e)
        {
            cbbOperation.Enabled = cbxOperation.Checked;
        }
        private void LbTreatmentWaitingList_DoubleClick(object sender, EventArgs e)
        {
            OnLbTreatmentWaitingList_DoubleClicked();
        }
        #region LbTreatmentWaitingList_DoubleClicked event things for C# 3.0
        public event EventHandler<LbTreatmentWaitingList_DoubleClickedEventArgs> LbTreatmentWaitingList_DoubleClicked;

        protected virtual void OnLbTreatmentWaitingList_DoubleClicked(LbTreatmentWaitingList_DoubleClickedEventArgs e)
        {
            if (LbTreatmentWaitingList_DoubleClicked != null)
                LbTreatmentWaitingList_DoubleClicked(this, e);
        }

        private LbTreatmentWaitingList_DoubleClickedEventArgs OnLbTreatmentWaitingList_DoubleClicked()
        {
            LbTreatmentWaitingList_DoubleClickedEventArgs args = new LbTreatmentWaitingList_DoubleClickedEventArgs();
            OnLbTreatmentWaitingList_DoubleClicked(args);

            return args;
        }

        /*private LbTreatmentWaitingList_DoubleClickedEventArgs OnLbTreatmentWaitingList_DoubleClickedForOut()
        {
            LbTreatmentWaitingList_DoubleClickedEventArgs args = new LbTreatmentWaitingList_DoubleClickedEventArgs();
            OnLbTreatmentWaitingList_DoubleClicked(args);

            return args;
        }*/

        public class LbTreatmentWaitingList_DoubleClickedEventArgs : EventArgs
        {


            /*public LbTreatmentWaitingList_DoubleClickedEventArgs()
            {
            }

            public LbTreatmentWaitingList_DoubleClickedEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (lbTreatmentWaitingList.Items.Count != 0)
                lbTreatmentWaitingList.SelectedIndex = 0;
            else
                return;

            var patient = DB.Patient.SearchFromTreatementControl(lbTreatmentWaitingList.SelectedItem.ToString());

            ShowPatientInfo(patient);
            LoadPrescription();
            OnBtnNext_Clicked();
        }
        #region BtnNext_Clicked event things for C# 3.0
        public event EventHandler<BtnNext_ClickedEventArgs> BtnNext_Clicked;

        protected virtual void OnBtnNext_Clicked(BtnNext_ClickedEventArgs e)
        {
            if (BtnNext_Clicked != null)
                BtnNext_Clicked(this, e);
        }

        private BtnNext_ClickedEventArgs OnBtnNext_Clicked()
        {
            BtnNext_ClickedEventArgs args = new BtnNext_ClickedEventArgs();
            OnBtnNext_Clicked(args);

            return args;
        }

        /*private BtnNext_ClickedEventArgs OnBtnNext_ClickedForOut()
        {
            BtnNext_ClickedEventArgs args = new BtnNext_ClickedEventArgs();
            OnBtnNext_Clicked(args);

            return args;
        }*/

        public class BtnNext_ClickedEventArgs : EventArgs
        {


            /*public BtnNext_ClickedEventArgs()
            {
            }

            public BtnNext_ClickedEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lbTreatmentWaitingList.Items.Count != 0)
                lbTreatmentWaitingList.SelectedIndex = 0;
            else
                return;

            lbTreatmentWaitingList.Items.Remove(lbTreatmentWaitingList.SelectedItem);
        }
        #endregion
    }
}
