using System;
using System.ComponentModel;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Helpers;

namespace Veterinary_Clinic.Winform.Forms
{
    public partial class TreatmentRegistForm : Form
    {
        public DataDeliver Deliver { get; set; } = new DataDeliver();

        public TreatmentRegistForm(Patient patient)
        {
            InitializeComponent();
            SetDatetimeFormat();

            InitDeliver();
            ReadData(patient);
        }

        #region Method
        private void InitDeliver()
        {
            Deliver.Number = 0;
            Deliver.ReservationTime = null;
        }
        private void ReadData(Patient patient)
        {
            txbName.Text = patient.Name;
            Deliver.PhoneNumber = patient.PhoneNumber;
        }
        public void SetDatetimeFormat()
        {
            string customFormat = "yy-MM-dd hh:mm:ss";

            dtpReservation.Format = DateTimePickerFormat.Custom;
            dtpReservation.CustomFormat = customFormat;
        }
        private void SetDeliver()
        {
            Deliver.PetName = txbName.Text;
            Deliver.ReservationTime = null;

            if (dtpReservation.Enabled == true)
                Deliver.ReservationTime = dtpReservation.Value;
        }
        #endregion

        #region Event
        private void CbxReservation_CheckedChanged(object sender, EventArgs e)
        {
            dtpReservation.Enabled = cbxReservation.Checked;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnRegist_Click(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.Owner;
            SetDeliver();

            if (!main.lbMainWaitingList.Items.Contains($"{Deliver.PetName}\t\t{Deliver.PhoneNumber}"))
            {
                main.lbMainWaitingList.Items.AddRange(new object[]
                        {$"{Deliver.PetName}\t\t{Deliver.PhoneNumber}"});

                main.TreatmentControl.TreatmentWaitingList.Items.Add(Deliver.PetName);
            }
            else
            {
                MessageBox.Show("중복");
            }
            Close();
        }
        private void DtpReservation_Validating(object sender, CancelEventArgs e)
        {
            if (dtpReservation.Value.Hour == 4)
                e.Cancel = true;
        }
        #endregion

        private void TreatmentRegistForm_Load(object sender, EventArgs e)
        {
            MainForm fa = (MainForm)this.Owner;
            txbNumber.Text = $"{fa.lbMainWaitingList.Items.Count + 1}";
        }
    }
}
