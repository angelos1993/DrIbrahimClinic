using System;

namespace DrIbrahimClinic.PL
{
    public partial class FrmPatientInoculations : MasterForm
    {
        public FrmPatientInoculations()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmPatientInoculations_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInoculation_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ClearForm()
        {
            txtPatientId.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            grpPanelPatientInoculations.Enabled = false;
        }

        #endregion
    }
}
