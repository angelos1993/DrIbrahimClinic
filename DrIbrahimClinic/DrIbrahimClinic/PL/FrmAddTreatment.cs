using System;
using System.Drawing;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.Utility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmAddTreatment : MasterForm
    {
        public FrmAddTreatment()
        {
            InitializeComponent();
        }

        #region Properties

        private TreatmentManager _treatmentManager;
        public TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());

        #endregion

        #region Events

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddNewTreatment(true);
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddNewTreatment();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void AddNewTreatment(bool addAnother = false)
        {
            if (string.IsNullOrEmpty(txtTreatmentName.Text.FullTrim()))
            {
                txtTreatmentName.BackColor = Color.HotPink;
                txtTreatmentName.Focus();
                return;
            }
            TreatmentManager.AddTreatment(new Treatment
            {
                Name = txtTreatmentName.Text.FullTrim()
            });
            if (addAnother)
            {
                txtTreatmentName.Text = string.Empty;
                txtTreatmentName.Focus();
            }
            else
                Close();
        }

        #endregion
    }
}