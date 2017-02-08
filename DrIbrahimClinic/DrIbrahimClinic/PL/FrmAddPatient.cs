using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DrIbrahimClinic.BBL;
using DrIbrahimClinic.DAL.Model;
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

        #region Properties

        private PatientManager _patientManager;
        public PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            var isFormValid = true;
            if (string.IsNullOrEmpty(txtName.Text.FullTrim()))
            {
                isFormValid = false;
                txtName.BackColor = Color.HotPink;
            }
            if (!isFormValid) return;
            var patient = new Patient
            {
                Name = txtName.Text,
                Birthdate = dtBirthdate.Value != default(DateTime) ? dtBirthdate.Value : (DateTime?) null,
                Gender = switchBtnGender.Value ? "M" : "F",
                Phone = txtPhone.Text.FullTrim(),
                Address = txtAddress.Text.FullTrim(),
                BirthType = switchBtnBirthType.Value ? (byte) 1 : (byte) 2,
                SucklingType = switchBtnSucklingType.Value ? (byte) 1 : (byte) 2
            };
            PatientManager.AddPatient(patient);
            ShowInfoMsg($"تم إضافة المريض بنجاح - رقم المريض هو {patient.Id}");
            Close();
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
