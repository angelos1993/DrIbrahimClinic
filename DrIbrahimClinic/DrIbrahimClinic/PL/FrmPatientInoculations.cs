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
            InoculationManager.AddInoculation(new Inoculation
            {
                Name = txtInoculationName.Text.FullTrim(),
                Date = dtInoculationDate.Value != default(DateTime) ? dtInoculationDate.Value : (DateTime?) null,
                PatientId = Patient.Id
            });
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

        #endregion

        #region Methods

        private void ResetForm()
        {
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            txtInoculationName.Text = string.Empty;
            dtInoculationDate.Value = default(DateTime);
            dgvPatientInoculations.DataSource = null;
            ShowOrHideControls(false);
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
                Date = inoculation.Date.ToString()
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