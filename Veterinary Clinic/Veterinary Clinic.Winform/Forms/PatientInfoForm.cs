using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Data;

namespace Veterinary_Clinic.Winform.Forms
{
    public partial class PatientInfoForm : Form
    {
        public Patient Patient { get; set; }
        public Companion Companion { get; set; }
        public PatientInfoForm()
        {
            InitializeComponent();
            Patient = new Patient();
            Companion = new Companion();

            btnModifier.Enabled = false;
            btnModifier.Visible = false;
            btnDone.Enabled = true;
            btnDone.Visible = true;
        }

        public PatientInfoForm(Patient patient)
        {
            InitializeComponent();

            Patient = patient;
            Companion = new Companion();

            Companion.CompanionID = patient.CompanionID;
            btnModifier.Enabled = true;
            btnModifier.Visible = true;
            btnDone.Enabled = false;
            btnDone.Visible = false;
        }

        #region Method
        private void ReadFromEntity()
        {
            txbName.Text = Patient.Name;
            txbCompanionName.Text = Patient.CompanionName;
            txbPhoneNum.Text = Patient.PhoneNumber;
            txbWeight.Text = Patient.Weight.ToString();
            if (txbName.Text.IsNullOrEmpty() == false)
            {
                dtpBirth.Value = Patient.Birth;
            }
            bdsBreeds.DataSource = DB.Breeds.GetAll();

            cbbBreedsId.SelectedValue = Patient.BreedsID;
            cbbSpeciesId.SelectedValue = Patient.SpeciesID;
        }

        private void WriteToEntity()
        {
            Patient.Name = txbName.Text;
            Patient.Birth = dtpBirth.Value;
            Patient.BreedsID = (int)cbbBreedsId.SelectedValue;
            Patient.Weight = int.Parse(txbWeight.Text);
            Patient.EmployeeID = 4;

            Companion.Name = txbCompanionName.Text;
            Companion.Phone = txbPhoneNum.Text;
        }
        #endregion

        #region Event
        private void BtnUndone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            WriteToEntity();
            Companion.CompanionID = DB.Companion.GetCount() + 1;
            Companion.Name = txbCompanionName.Text;
            Companion.Phone = txbPhoneNum.Text;
            DB.Companion.Insert(Companion);

            Patient.CompanionID = Companion.CompanionID;

            DB.Patient.Insert(Patient);
            Close();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            DB.Companion.Update(Companion);
            DB.Patient.Update(Patient);
            Close();
        }

        private void PatientBaseForm_Load(object sender, EventArgs e)
        {
            bdsSpecies.DataSource = DB.Species.GetAll();

            if (Patient.Name != null)
                ReadFromEntity();
        }

        private void CbbSpeciesId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbSpeciesId.SelectedValue == null)
                return;

            List<Breeds> list = DB.Breeds.GetBreeds((int)cbbSpeciesId.SelectedValue);

            bdsBreeds.DataSource = list;
        }
        #endregion
    }
}
