using System;

namespace DrIbrahimClinic.PL
{
    public partial class FrmEditTreatment : MasterForm
    {
        public FrmEditTreatment()
        {
            InitializeComponent();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTreatmentOldName.Text = txtTreatmentNewName.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
