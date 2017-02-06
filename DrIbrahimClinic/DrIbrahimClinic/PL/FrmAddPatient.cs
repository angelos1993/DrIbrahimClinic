using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DrIbrahimClinic.Utility.MessageBoxUtility;
using static DrIbrahimClinic.Utility.StringExtensions;

namespace DrIbrahimClinic.PL
{
    public partial class FrmAddPatient : MasterForm
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            var isFormValid = true;
            if (string.IsNullOrEmpty(txtName.Text.FullTrim()))
            {
                isFormValid = false;
                ShowErrorMsg("يجب إدخال اسم المريض");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods
        
        private void ResetForm()
        {
            txtName.Text = string.Empty;
            dtBirthdate.Value = new DateTime(1, 1, 1);
            switchBtnGender.Value = true;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            switchBtnBirthType.Value = true;
            switchBtnSucklingType.Value = true;
        }

        #endregion
    }
}
