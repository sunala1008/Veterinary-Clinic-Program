using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Library.Data;

namespace Veterinary_Clinic.Winform.Forms
{
    public partial class EmployeeInfoForm : Form
    {
        public Employee Employee { get; set; }
        public EmployeeInfoForm()
        {
            InitializeComponent();
            Employee = new Employee();

            btnModifier.Enabled = false;
            btnModifier.Visible = false;
            btnDone.Enabled = true;
            btnDone.Visible = true;
        }
        public EmployeeInfoForm(Employee employee)
        {
            InitializeComponent();

            Employee = employee;

            btnModifier.Enabled = true;
            btnModifier.Visible = true;
            btnDone.Enabled = false;
            btnDone.Visible = false;
        }

        #region Method
        private void ReadFromEntity()
        {
            txbName.Text = Employee.Name;
            txbPhoneNum.Text = Employee.PhoneNum;
            txbMail.Text = Employee.Mail;
            if (txbName.Text.IsNullOrEmpty() == false)
            {
                dtpBirth.Value = Employee.Birth;
                dtpHireDate.Value = Employee.HireDate;
                if (dtpFireDate.Enabled == true)
                    dtpFireDate.Value = (DateTime)Employee.FireDate;
            }
        }
        private void WriteToEntity()
        {
            Employee.Name = txbName.Text;
            Employee.Mail = txbMail.Text;
            Employee.PhoneNum = txbPhoneNum.Text;
            Employee.Birth = dtpBirth.Value;
            Employee.HireDate = dtpHireDate.Value;
            if (Employee.FireDate != null)
            {
                cbxFireDate.Checked = true;
                Employee.FireDate = dtpFireDate.Value;
            }
        }
        #endregion

        #region Event
        private void BtnUndone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbxFireDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFireDate.Enabled = cbxFireDate.Checked;
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            DB.Employee.Insert(Employee);
            Close();
        }

        private void EmployeeInfoForm_Load(object sender, EventArgs e)
        {
            if (Employee.Name != null)
                ReadFromEntity();
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            DB.Employee.Update(Employee);
            Close();
        }
        #endregion
    }
}
