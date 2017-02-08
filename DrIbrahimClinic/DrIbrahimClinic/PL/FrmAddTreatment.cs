using System;
using System.Drawing;
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
            AddNewTreatment(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddNewTreatment();
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
                return;
            }
            TreatmentManager.AddTreatment(new Treatment
            {
                Name = txtTreatmentName.Text.FullTrim()
            });
            if (addAnother)
                txtTreatmentName.Text = string.Empty;
            else
                Close();
        }

        #endregion
    }
}