using System;
using System.Linq;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;

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

        #endregion

        #region Events

        private void FrmSearchPatient_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        #endregion

        #region Methods

        private void FillGrid(Func<Patient, bool> where = null)
        {
            dgvPatients.DataSource = where == null
                ? PatientManager.GetAllPatients().ToList()
                : PatientManager.GetAllPatients().Where(where).ToList();
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
            dtPatientBirthdate.Value = new DateTime(1, 1, 1);
            txtPatientPhone.Text = string.Empty;
        }

        private void FindPatient(object sender, EventArgs e)
        {
            FillGrid(patient => patient.Name.Contains(txtPatientName.Text));
        }

        #endregion
    }
}