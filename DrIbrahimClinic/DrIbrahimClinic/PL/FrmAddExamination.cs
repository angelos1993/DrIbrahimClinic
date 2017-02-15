using System;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;
using static DrIbrahimClinic.Utility.Constants;
using DrIbrahimClinic.Properties;

namespace DrIbrahimClinic.PL
{
    public partial class FrmAddExamination : MasterForm
    {
        public FrmAddExamination()
        {
            InitializeComponent();
        }

        #region Properties

        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        public Patient Patient { get; set; }

        public Examination Examination { get; set; }

        #endregion

        #region Events

        #region Form Load

        private void FrmAddExamination_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        #endregion

        #region Patient

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (intInputPatientId.Value == 0 && string.IsNullOrEmpty(txtPatientName.Text))
            {
                ShowInfoMsg("يجب إدخال رقم المريض او اسم المريض");
                Cursor = Cursors.Default;
                return;
            }
            Patient = intInputPatientId.Value != 0
                ? PatientManager.GetPatientById(intInputPatientId.Value)
                : PatientManager.GetPatientByName(txtPatientName.Text);
            if (Patient != null)
                ShowPatientData(Patient);
            else
                ShowErrorMsg("لا يوجد مريض بهذا الرقم او الاسم");
            Cursor = Cursors.Default;
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (btnAddNewPatient.Text == @"جديد")
            {
                ClearPatientData();
                ShowOrHidePatientControls(AddExaminationFormMode.AddNew);
                btnAddNewPatient.Text = @"حفظ";
                btnAddNewPatient.Image = Resources.Save;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPatientName.Text.FullTrim()))
                {
                    txtPatientName.BackColor = ErrorColor;
                    Cursor = Cursors.Default;
                    return;
                }
                Patient = new Patient
                {
                    Name = txtPatientName.Text.FullTrim(),
                    Birthdate =
                        dtPatientBirthdate.Value != default(DateTime) ? dtPatientBirthdate.Value : (DateTime?) null,
                    Gender = switchBtnPatientGender.Value ? "M" : "F",
                    Phone = txtPatientPhone.Text.FullTrim(),
                    Address = txtPatientAddress.Text.FullTrim(),
                    BirthType = switchBtnPatientBirthType.Value ? (byte) 1 : (byte) 2,
                    SucklingType = switchBtnPatientSucklingType.Value ? (byte) 1 : (byte) 2
                };
                PatientManager.AddPatient(Patient);
                ShowInfoMsg($"تم إضافة المريض بنجاح\nرقم المريض هو: {Patient.Id}");
                ShowPatientData(Patient);
                btnAddNewPatient.Text = @"جديد";
                btnAddNewPatient.Image = Resources.Add;
            }
            Cursor = Cursors.Default;
        }

        private void btnEditPatientData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (btnEditPatientData.Text == @"تعديل")
            {
                ShowOrHidePatientControls(AddExaminationFormMode.Edit);
                btnEditPatientData.Text = @"حفظ";
                btnEditPatientData.Image = Resources.Save;
            }
            else
            {
                ShowOrHidePatientControls(AddExaminationFormMode.HasPatient);
                if (string.IsNullOrEmpty(txtPatientName.Text.FullTrim()))
                {
                    txtPatientName.BackColor = ErrorColor;
                    Cursor = Cursors.Default;
                    return;
                }
                Patient.Name = txtPatientName.Text.FullTrim();
                Patient.Birthdate = dtPatientBirthdate.Value != default(DateTime)
                    ? dtPatientBirthdate.Value
                    : (DateTime?) null;
                Patient.Gender = switchBtnPatientGender.Value ? "M" : "F";
                Patient.Phone = txtPatientPhone.Text.FullTrim();
                Patient.Address = txtPatientAddress.Text.FullTrim();
                Patient.BirthType = switchBtnPatientBirthType.Value ? (byte) 1 : (byte) 2;
                Patient.SucklingType = switchBtnPatientSucklingType.Value ? (byte) 1 : (byte) 2;
                PatientManager.UpdatePatient(Patient);
                btnEditPatientData.Text = @"تعديل";
                btnEditPatientData.Image = Resources.Edit;
            }
            Cursor = Cursors.Default;
        }

        private void btnClearPatientData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearPatientPanel();
            Cursor = Cursors.Default;
        }

        private void btnAddMedicalHistory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
        }

        private void btnAddInoculation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
        }

        #endregion

        #region Examination

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearExaminationPanel();
        }

        private void btnPrintRoshetta_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #endregion

        #region Methods

        private void ClearForm()
        {
            ClearPatientPanel();
            ClearPreviousVisitsDgv();
            ClearExaminationPanel();
        }

        private void ClearPatientPanel()
        {
            ShowOrHidePatientControls(AddExaminationFormMode.Normal);
            btnAddNewPatient.Text = @"جديد";
            btnAddNewPatient.Image = Resources.Add;
            expPanelMedicalHistory.Expanded = false;
            expPanelInoculations.Expanded = false;
            ClearPatientData();
        }

        private void ClearPatientData()
        {
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            dtPatientBirthdate.Value = default(DateTime);
            switchBtnPatientGender.Value = true;
            txtPatientPhone.Text = string.Empty;
            txtPatientAddress.Text = string.Empty;
            switchBtnPatientBirthType.Value = true;
            switchBtnPatientSucklingType.Value = true;
            //clear Medical History
            //clear Inoculations
        }

        private void ShowOrHidePatientControls(AddExaminationFormMode mode)
        {
            intInputPatientId.Enabled = mode == AddExaminationFormMode.Normal;
            txtPatientName.Enabled = mode == AddExaminationFormMode.Normal || mode == AddExaminationFormMode.AddNew ||
                                     mode == AddExaminationFormMode.Edit;
            btnFindPatient.Enabled = mode == AddExaminationFormMode.Normal;
            dtPatientBirthdate.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            switchBtnPatientGender.Enabled = mode == AddExaminationFormMode.AddNew ||
                                             mode == AddExaminationFormMode.Edit;
            txtPatientPhone.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            txtPatientAddress.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            switchBtnPatientBirthType.Enabled = mode == AddExaminationFormMode.AddNew ||
                                                mode == AddExaminationFormMode.Edit;
            switchBtnPatientSucklingType.Enabled = mode == AddExaminationFormMode.AddNew ||
                                                   mode == AddExaminationFormMode.Edit;
            expPanelMedicalHistory.Enabled = mode == AddExaminationFormMode.Edit ||
                                             mode == AddExaminationFormMode.HasPatient;
            expPanelInoculations.Enabled = mode == AddExaminationFormMode.Edit ||
                                           mode == AddExaminationFormMode.HasPatient;
            btnAddNewPatient.Enabled = mode == AddExaminationFormMode.Normal ||
                                       mode == AddExaminationFormMode.HasPatient ||
                                       mode == AddExaminationFormMode.AddNew;
            btnEditPatientData.Enabled = mode == AddExaminationFormMode.Edit ||
                                         mode == AddExaminationFormMode.HasPatient;
        }

        private void ShowPatientData(Patient patient)
        {
            ShowOrHidePatientControls(AddExaminationFormMode.HasPatient);
            intInputPatientId.Value = patient.Id;
            txtPatientName.Text = patient.Name;
            dtPatientBirthdate.Value = patient.Birthdate ?? default(DateTime);
            switchBtnPatientGender.Value = patient.Gender == "M";
            txtPatientPhone.Text = patient.Phone ?? string.Empty;
            txtPatientAddress.Text = patient.Address ?? string.Empty;
            switchBtnPatientBirthType.Value = patient.BirthType == 1;
            switchBtnPatientSucklingType.Value = patient.SucklingType == 1;
        }

        private void ClearPreviousVisitsDgv()
        {
            dgvPreviousVisits.Rows.Clear();
            dgvPreviousVisits.Refresh();
        }

        private void ClearExaminationPanel()
        {

        }

        #endregion
    }
}