using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.InputLanguageUtility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmSearchPatient : FrmMaster
    {
        public FrmSearchPatient()
        {
            InitializeComponent();
        }

        #region Properties

        private PatientManager _patientManager;
        public PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private IEnumerable<Patient> _patients;
        private IEnumerable<Patient> Patients => _patients ?? (_patients = PatientManager.GetAllPatients());

        #endregion

        #region Events

        private void FrmSearchPatient_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetTextBoxesInputLanguages();
        }

        private void FindPatient(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (intInputPatientId.Value != 0)
                FillGrid(patient => patient.Id == intInputPatientId.Value);
            else
                FillGrid(
                    patient =>
                        patient.Name.Contains(txtPatientName.Text.FullTrim()) &&
                        patient.Phone.Contains(txtPatientPhone.Text.FullTrim()));
            Cursor = Cursors.Default;
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearSearch();
            Cursor = Cursors.Default;
        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف المريض المحدد؟") != DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            var patient = PatientManager.GetPatientById(int.Parse(dgvPatients.SelectedRows[0].Cells[0].Value.ToString()));
            if (patient == null)
                return;
            if (patient.Examinations.Any() || patient.MedicalHistories.Any() || patient.Inoculations.Any())
            {
                ShowErrorMsg("لا يمكن حذف هذا المريض حيث أنة لدية كشف / تطعيم / تاريخ مرضي");
                Cursor = Cursors.Default;
                return;
            }
            PatientManager.DeletePatient(patient);
            FillGrid();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void FillGrid(Func<Patient, bool> where = null)
        {
            dgvPatients.DataSource = Patients.Where(where ?? (p => true)).OrderBy(patient => patient.Name).Select(patient => new PatientVm
            {
                Id = patient.Id,
                Name = patient.Name,
                Birthdate = patient.Birthdate,
                Phone = patient.Phone,
                Address = patient.Address,
                Gender = patient.Gender == "M" ? "ولد" : "بنت",
                BirthType = patient.BirthType == 1 ? "طبيعي" : "قيصري",
                SucklingType = patient.SucklingType == 1 ? "طبيعي" : "صناعي"
            }).ToList();
        }

        private void ClearSearch()
        {
            ClearForm();
            FillGrid();
        }

        private void ClearForm()
        {
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            txtPatientPhone.Text = string.Empty;
        }

        private void SetTextBoxesInputLanguages()
        {
            txtPatientName.GotFocus += SetArabicInputLanguage;
            txtPatientPhone.GotFocus += SetArabicInputLanguage;
        }

        #endregion
    }
}