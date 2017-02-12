using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;
using static DrIbrahimClinic.Utility.Utility;
using static DrIbrahimClinic.Utility.DateTimeExtensions;

namespace DrIbrahimClinic.PL
{
    public partial class FrmPatientInoculations : MasterForm
    {
        public FrmPatientInoculations()
        {
            InitializeComponent();
        }

        #region Properties

        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private InoculationManager _inoculationManager;
        private InoculationManager InoculationManager
            => _inoculationManager ?? (_inoculationManager = new InoculationManager());

        private IEnumerable<Patient> _patients;
        private IEnumerable<Patient> Patients => _patients ?? (_patients = PatientManager.GetAllPatients());

        public Patient Patient { get; set; }

        #endregion

        #region Events

        private void FrmPatientInoculations_Load(object sender, EventArgs e)
        {
            ResetForm();
            SetAutoCompletion();
        }

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
                ? Patients.FirstOrDefault(patient => patient.Id == intInputPatientId.Value)
                : Patients.FirstOrDefault(patient => patient.Name == txtPatientName.Text);
            if (Patient != null)
                ShowPatientInoculationsData(Patient);
            else
                ShowErrorMsg("لا يوجد مريض بهذا الرقم او الاسم");
            Cursor = Cursors.Default;
        }

        private void btnAddInoculation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtInoculationName.Text.FullTrim()))
            {
                ShowErrorMsg("يجب إدخال اسم التطعيم");
                return;
            }
            var inoculation = new Inoculation
            {
                Name = txtInoculationName.Text.FullTrim(),
                Date = dtInoculationDate.Value != default(DateTime) ? dtInoculationDate.Value : (DateTime?) null,
                PatientId = Patient.Id
            };
            InoculationManager.AddInoculation(inoculation);
            Patient.Inoculations.Add(inoculation);
            ClearInoculationInputs();
            FillGrid();
            Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPatientInoculations_DoubleClick(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف التطعيم المحدد؟") != DialogResult.Yes)
                return;
            var inoculation =
                InoculationManager.GetInoculationByNameAndPatientId(
                    dgvPatientInoculations.SelectedRows[0].Cells[0].Value.ToString(), Patient.Id);
            if (inoculation == null)
                return;
            InoculationManager.DeleteInoculation(inoculation);
            Patient.Inoculations.Remove(inoculation);
            FillGrid();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            ClearInoculationInputs();
            dgvPatientInoculations.DataSource = null;
            ShowOrHideControls(false);
        }

        private void ClearInoculationInputs()
        {
            txtInoculationName.Text = string.Empty;
            dtInoculationDate.Value = default(DateTime);
        }

        private void ShowOrHideControls(bool isEnabled)
        {
            grpPanelPatientInoculations.Enabled = isEnabled;
            grpPanelPatientData.Enabled = !isEnabled;
        }

        private void ShowPatientInoculationsData(Patient patient)
        {
            ShowOrHideControls(true);
            intInputPatientId.Value = patient.Id;
            txtPatientName.Text = patient.Name;
            FillGrid();
        }

        private void FillGrid()
        {
            dgvPatientInoculations.DataSource = Patient.Inoculations.Select(inoculation => new InoculationVm
            {
                Name = inoculation.Name,
                Date = inoculation.Date?.ToFormattedArabicDate()
            }).ToList();
        }

        private void SetAutoCompletion()
        {
            var namesCollection = new AutoCompleteStringCollection();
            namesCollection.AddRange(Patients.Select(p => p.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtPatientName, namesCollection);
        }

        #endregion
    }
}