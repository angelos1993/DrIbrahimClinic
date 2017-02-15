using System;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;

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

        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            ShowOrHidePatientInputs(true);
        }

        private void btnEditPatientData_Click(object sender, EventArgs e)
        {

        }

        private void btnClearPatientData_Click(object sender, EventArgs e)
        {
            ClearPatientData();
        }

        private void btnAddMedicalHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInoculation_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Examination

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearExaminationData();
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
            ClearPatientData();
            ClearPreviousVisitsDgv();
            ClearExaminationData();
        }

        #region Clear Patient Tab

        private void ClearPatientData(bool isEnabled = false)
        {
            ShowOrHidePatientControls(isEnabled);
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            switchBtnPatientGender.Value = true;
            txtPatientPhone.Text = string.Empty;
            txtPatientAddress.Text = string.Empty;
            switchBtnPatientBirthType.Value = true;
            switchBtnPatientSucklingType.Value = true;
            //clear Medical History
            //clear Inoculations
        }

        private void ShowOrHidePatientControls(bool isEnabled = false)
        {
            ShowOrHidePatientInputs(isEnabled);
            btnEditPatientData.Enabled = isEnabled;
            expPanelMedicalHistory.Enabled = isEnabled;
            expPanelInoculations.Enabled = isEnabled;
        }

        private void ShowOrHidePatientInputs(bool isEnabled = false)
        {
            intInputPatientId.Enabled = !isEnabled;
            btnFindPatient.Enabled = !isEnabled;
            dtPatientBirthdate.Enabled = isEnabled;
            switchBtnPatientGender.Enabled = isEnabled;
            txtPatientPhone.Enabled = isEnabled;
            txtPatientAddress.Enabled = isEnabled;
            switchBtnPatientBirthType.Enabled = isEnabled;
            switchBtnPatientSucklingType.Enabled = isEnabled;
            btnAddNewPatient.Enabled = !isEnabled;
        }

        #endregion

        #region Clear Previous Visits Tab

        private void ClearPreviousVisitsDgv()
        {
            dgvPreviousVisits.Rows.Clear();
            dgvPreviousVisits.Refresh();
        }

        #endregion

        #region Clear Examination Tab

        private void ClearExaminationData()
        {

        }

        #endregion

        #endregion
    }
}