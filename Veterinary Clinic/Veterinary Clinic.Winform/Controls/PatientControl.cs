using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Veterinary_Clinic.Library.Data;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Helpers;
using Veterinary_Clinic.Winform.Forms;

namespace Veterinary_Clinic.Winform.Controls
{
    public partial class PatientControl : UserControl
    {
        public PatientControl()
        {
            InitializeComponent();
        }

        #region Method
        public void LoadSpecies()
        {
            bdsSpecies.DataSource = DB.Species.GetAll();
        }
        public void SetPatientDataSource(List<Patient> patient)
        {
            bdsPatient.DataSource = patient;
            lblCount.Text = $"총 : {patient.Count}명";
        }
        public object CurrnetRowDataBoundItem
        {
            get
            {
                return dgvList.CurrentRow.DataBoundItem;
            }
        }
        private static void ShowPatientInfoForm(Patient patient)
        {
            Form form = new PatientInfoForm(patient);
            FormHelper.MoveToCenter(form);
            form.ShowDialog();
        }
        #endregion

        #region Controls Event
        private void CbxSpecies_CheckedChanged(object sender, EventArgs e)
        {
            cbbSpecies.Enabled = cbxSpecies.Checked;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string phoneNum = txbPhoneNum.Text;
            string petName = txbPetName.Text;
            int? speciesId = null;

            if (cbbSpecies.Enabled == true)
                speciesId = (int)cbbSpecies.SelectedValue;

            OnBtnSearch_Clicked(phoneNum, petName, speciesId);
        }

        #region BtnSearch_Clicked event things for C# 3.0
        public event EventHandler<BtnSearch_ClickedEventArgs> BtnSearch_Clicked;

        protected virtual void OnBtnSearch_Clicked(BtnSearch_ClickedEventArgs e)
        {
            if (BtnSearch_Clicked != null)
                BtnSearch_Clicked(this, e);
        }

        private BtnSearch_ClickedEventArgs OnBtnSearch_Clicked(string phoneNum, string petName, int? speciesId)
        {
            BtnSearch_ClickedEventArgs args = new BtnSearch_ClickedEventArgs(phoneNum, petName, speciesId);
            OnBtnSearch_Clicked(args);

            return args;
        }

        private BtnSearch_ClickedEventArgs OnBtnSearch_ClickedForOut()
        {
            BtnSearch_ClickedEventArgs args = new BtnSearch_ClickedEventArgs();
            OnBtnSearch_Clicked(args);

            return args;
        }

        public class BtnSearch_ClickedEventArgs : EventArgs
        {
            public string PhoneNum { get; set; }
            public string PetName { get; set; }
            public int? SpeciesId { get; set; }

            public BtnSearch_ClickedEventArgs()
            {
            }

            public BtnSearch_ClickedEventArgs(string phoneNum, string petName, int? speciesId)
            {
                PhoneNum = phoneNum;
                PetName = petName;
                SpeciesId = speciesId;
            }
        }
        #endregion

        private void BtnTreatmentRegist_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
                MessageBox.Show("환자를 선택해 주세요.");
            else
                OnBtnTreatmentRegist_Clicked();
        }

        #region BtnTreatmentRegist_Clicked event things for C# 3.0
        public event EventHandler<BtnTreatmentRegist_ClickedEventArgs> BtnTreatmentRegist_Clicked;

        protected virtual void OnBtnTreatmentRegist_Clicked(BtnTreatmentRegist_ClickedEventArgs e)
        {
            if (BtnTreatmentRegist_Clicked != null)
                BtnTreatmentRegist_Clicked(this, e);
        }

        private BtnTreatmentRegist_ClickedEventArgs OnBtnTreatmentRegist_Clicked()
        {
            BtnTreatmentRegist_ClickedEventArgs args = new BtnTreatmentRegist_ClickedEventArgs();
            OnBtnTreatmentRegist_Clicked(args);

            return args;
        }

        /*private BtnTreatmentRegist_ClickedEventArgs OnBtnTreatmentRegist_ClickedForOut()
        {
            BtnTreatmentRegist_ClickedEventArgs args = new BtnTreatmentRegist_ClickedEventArgs();
            OnBtnTreatmentRegist_Clicked(args);

            return args;
        }*/

        public class BtnTreatmentRegist_ClickedEventArgs : EventArgs
        {


            /*public BtnTreatmentRegist_ClickedEventArgs()
            {
            }

            public BtnTreatmentRegist_ClickedEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnRegist_Click(object sender, EventArgs e)
        {
            Form form = new PatientInfoForm();
            FormHelper.MoveToCenter(form);
            form.ShowDialog();
        }

        private void DgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(CurrnetRowDataBoundItem is Patient patient))
                return;

            ShowPatientInfoForm(patient);
        }

        private void DgvList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                Patient patient = new Patient();

                ShowPatientInfoForm(patient);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (!(CurrnetRowDataBoundItem is Patient patient))
                    return;

                Companion companion = new Companion()
                {
                    CompanionID = patient.CompanionID,
                    Name = patient.CompanionName,
                    Phone = patient.PhoneNumber
                };

                if (FormHelper.IsDeleteOrNot())
                {
                    DB.Patient.Delete(patient);
                    DB.Companion.Delete(companion);
                }
            }
        }

        private void DgvList_MenuClick(object obj, EventArgs e)
        {
            if (!(CurrnetRowDataBoundItem is Patient patient))
                return;

            MenuItem menuItem = (MenuItem)obj;
            string str = menuItem.Text;

            if (str == "수정")
            {
                ShowPatientInfoForm(patient);
            }

            if (str == "진료등록")
            {
                btnTreatmentRegist.PerformClick();
            }
        }

        private void DgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                EventHandler handler = new EventHandler(DgvList_MenuClick);

                MenuItem[] items =
                {
                    new MenuItem("수정", handler),
                    new MenuItem("진료등록", handler)
                };

                ContextMenu = new ContextMenu(items);
            }
        }
        #endregion
    }
}
