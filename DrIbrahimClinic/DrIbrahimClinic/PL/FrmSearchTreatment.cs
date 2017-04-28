using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.InputLanguageUtility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmSearchTreatment : FrmMaster
    {
        public FrmSearchTreatment()
        {
            InitializeComponent();
        }

        #region Properties

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());

        private IEnumerable<Treatment> _treatments;
        private IEnumerable<Treatment> Treatments => _treatments ?? (_treatments = TreatmentManager.GetAllTreatments());

        #endregion

        #region Events

        private void FrmSearchTreatment_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetTextBoxesInputLanguages();
        }

        private void FindTreatment(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (radStartsWith.Checked)
                FillGrid(treatment => treatment.Name.ToLower().StartsWith(txtTreatmentName.Text.FullTrim().ToLower()));
            else
                FillGrid(treatment => treatment.Name.ToLower().Contains(txtTreatmentName.Text.FullTrim().ToLower()));
            Cursor = Cursors.Default;
        }

        private void dgvTreatments_DoubleClick(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف العلاج المحدد؟") != DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            var treatment = TreatmentManager.GeTreatmentByName(dgvTreatments.SelectedRows[0].Cells[0].Value.ToString());
            if (treatment == null)
                return;
            Treatments.ToList().Remove(treatment);
            TreatmentManager.DeleteTreatment(treatment);
            FillGrid();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void FillGrid(Func<Treatment, bool> where = null)
        {
            dgvTreatments.DataSource = Treatments.Where(where ?? (p => true)).Select(treatment => new TreatmentVm
            {
                //Id = treatment.Id,
                Name = treatment.Name
            }).OrderBy(treatment => treatment.Name).ToList();
        }

        private void SetTextBoxesInputLanguages()
        {
            txtTreatmentName.GotFocus += SetEnglishInputLanguage;
        }

        #endregion
    }
}