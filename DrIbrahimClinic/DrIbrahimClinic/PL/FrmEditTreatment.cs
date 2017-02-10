using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.Constants;
using static DrIbrahimClinic.Utility.Utility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;

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

        private IEnumerable<Treatment> _treatments;
        private IEnumerable<Treatment> Treatments => _treatments ?? (_treatments = TreatmentManager.GetAllTreatments());

        public Treatment Treatment { get; set; }

        #endregion

        #region Events

        private void FrmEditTreatment_Load(object sender, EventArgs e)
        {
            SetAutoCompletion();
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
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void EditTreatment(bool editAnother = false)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(txtTreatmentOldName.Text.FullTrim()))
            {
                txtTreatmentOldName.BackColor = ErrorColor;
                txtTreatmentOldName.Focus();
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtTreatmentNewName.Text.FullTrim()))
            {
                txtTreatmentNewName.BackColor = ErrorColor;
                isValid = false;
            }
            if (!isValid) return;
            Treatment = TreatmentManager.GeTreatmentByName(txtTreatmentOldName.Text);
            if (Treatment == null)
                ShowErrorMsg("لا يوجد علاج بهذا الاسم");
            else
            {
                Treatment.Name = txtTreatmentNewName.Text;
                TreatmentManager.UpdateTreatment(Treatment);
                if (!editAnother)
                    Close();
                ResetForm();
                txtTreatmentOldName.Focus();
                _treatments = null;
                SetAutoCompletion();
            }
        }

        private void ResetForm()
        {
            txtTreatmentOldName.Text = txtTreatmentNewName.Text = string.Empty;
        }

        private void SetAutoCompletion()
        {
            var namesCollection = new AutoCompleteStringCollection();
            namesCollection.AddRange(Treatments.Select(t => t.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtTreatmentOldName, namesCollection);
        }

        #endregion
    }
}