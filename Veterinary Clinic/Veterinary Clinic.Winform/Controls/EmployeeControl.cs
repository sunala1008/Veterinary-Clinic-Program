using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Veterinary_Clinic.Library;
using Veterinary_Clinic.Winform.Forms;
using Veterinary_Clinic.Library.Helpers;
using Veterinary_Clinic.Library.Data;

namespace Veterinary_Clinic.Winform.Controls
{
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();
        }

        #region Method
        public object CurrnetRowDataBoundItem
        {
            get
            {
                return dgvList.CurrentRow.DataBoundItem;
            }
        }
        public void SetEmployeeData(List<Employee> employee)
        {
            bdsEmployee.DataSource = employee;
            lblCount.Text = $"총 : {employee.Count}명";
        }
        private static void ShowEmployeeInfoForm(Employee employee)
        {
            Form form = new EmployeeInfoForm(employee);
            form.MoveToCenter();
            form.ShowDialog();
        }
        #endregion

        #region Event
        // 직원 검색
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txbEmployeeName.Text;
            string num = txbPhoneNum.Text;

            OnRegistButtonClicked(name, num);
        }

        #region RegistButtonClicked event things for C# 3.0
        public event EventHandler<RegistButtonClickedEventArgs> RegistButtonClicked;

        protected virtual void OnRegistButtonClicked(RegistButtonClickedEventArgs e)
        {
            if (RegistButtonClicked != null)
                RegistButtonClicked(this, e);
        }

        private RegistButtonClickedEventArgs OnRegistButtonClicked(string name, string num)
        {
            RegistButtonClickedEventArgs args = new RegistButtonClickedEventArgs(name, num);
            OnRegistButtonClicked(args);

            return args;
        }

        private RegistButtonClickedEventArgs OnRegistButtonClickedForOut()
        {
            RegistButtonClickedEventArgs args = new RegistButtonClickedEventArgs();
            OnRegistButtonClicked(args);

            return args;
        }

        public class RegistButtonClickedEventArgs : EventArgs
        {
            public string Name { get; set; }
            public string Num { get; set; }

            public RegistButtonClickedEventArgs()
            {
            }

            public RegistButtonClickedEventArgs(string name, string num)
            {
                Name = name;
                Num = num;
            }
        }
        #endregion

        // 직원 등록
        private void BtnRegist_Click(object sender, EventArgs e)
        {
            Form form = new EmployeeInfoForm();
            FormHelper.MoveToCenter(form);
            form.ShowDialog();
        }

        // 더블클릭 시 수정
        private void DgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dgvList.CurrentRow.DataBoundItem is Employee employee))
                return;

            Form form = new EmployeeInfoForm(employee);
            FormHelper.MoveToCenter(form);
            form.ShowDialog();
        }

        private void DgvList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) // Insert키 => 등록
            {
                Employee employee = new Employee();
                ShowEmployeeInfoForm(employee);
            }
            else if (e.KeyCode == Keys.Delete) // Delete키 => 삭제
            {
                if (!(CurrnetRowDataBoundItem is Employee employee))
                    return;

                if (FormHelper.IsDeleteOrNot())
                {
                    DB.Employee.Delete(employee);
                }
            }
        }
        #endregion
    }
}
