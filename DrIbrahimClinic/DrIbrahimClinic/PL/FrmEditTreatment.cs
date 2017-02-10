using System;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.Constants;

namespace DrIbrahimClinic.PL
{
    public partial class FrmEditTreatment : MasterForm
    {
        public FrmEditTreatment()
        {
            InitializeComponent();
        }

        #region Properties

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());

        #endregion

        #region Events

        private void FrmEditTreatment_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditTreatment(true);
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditTreatment();
            Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTreatmentOldName.Text = txtTreatmentNewName.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void EditTreatment(bool editAnother = false)
        {
            if (string.IsNullOrEmpty(txtTreatmentOldName.Text.FullTrim()))
            {
                txtTreatmentOldName.BackColor = ErrorColor;
                txtTreatmentOldName.Focus();
            }
            if (string.IsNullOrEmpty(txtTreatmentNewName.Text.FullTrim()))
            {
                txtTreatmentNewName.BackColor = ErrorColor;
            }
        }

        #endregion
    }
}