using System;

namespace DrIbrahimClinic.PL
{
    public partial class FrmEditPatient : MasterForm
    {
        public FrmEditPatient()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmEditPatient_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

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
            dtBirthdate.Enabled = false;
            switchBtnGender.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            switchBtnBirthType.Enabled = false;
            switchBtnSucklingType.Enabled = false;
            btnSave.Enabled = false;

            txtId.Text = string.Empty;
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
