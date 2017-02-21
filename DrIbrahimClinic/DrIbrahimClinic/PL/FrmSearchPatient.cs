using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.InputLanguageUtility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmSearchPatient : MasterForm
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
            if (intInputPatientId.Value != 0)
                FillGrid(patient => patient.Id == intInputPatientId.Value);
            else
                FillGrid(
                    patient =>
                        patient.Name.Contains(txtPatientName.Text.FullTrim()) &&
                        patient.Phone.Contains(txtPatientPhone.Text.FullTrim()));
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        #endregion

        #region Methods

        private void FillGrid(Func<Patient, bool> where = null)
        {
            dgvPatients.DataSource = Patients.Where(where ?? (p => true)).Select(patient => new PatientVm
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