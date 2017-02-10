using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;

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
        }

        private void FindPatient(object sender, EventArgs e)
        {
            int patientId;
            if (!string.IsNullOrEmpty(txtPatientId.Text.FullTrim()) && int.TryParse(txtPatientId.Text, out patientId))
                FillGrid(patient => patient.Id == patientId);
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
            dgvPatients.DataSource = Patients.Where(where ?? (p => 1 == 1)).Select(patient => new PatientVm
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
            txtPatientId.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtPatientPhone.Text = string.Empty;
        }
        
        #endregion
    }
}