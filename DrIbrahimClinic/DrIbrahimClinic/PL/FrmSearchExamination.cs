using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmSearchExamination : MasterForm
    {
        public FrmSearchExamination()
        {
            InitializeComponent();
        }

        #region Properties

        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        private IEnumerable<Examination> _examinations;

        private IEnumerable<Examination> Examinations
            => _examinations ?? (_examinations = ExaminationManager.GetAllExaminations());

        #endregion

        #region Events

        private void FrmSearchExamination_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FindExamination(object sender, EventArgs e)
        {
            
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        #endregion

        #region Methods

        private void FillGrid(Func<Examination, bool> where = null)
        {
            dgvExaminations.DataSource =
                Examinations.Where(where ?? (p => true)).Select(examination => new ExaminationVm
                {
                    PatientId = examination.PatientId,
                    PatientName = examination.Patient.Name,
                    ExaminationDate = examination.Date.ToFormattedArabicDate(),
                    ExaminationType = examination.ExaminationType == 1 ? "كشف" : "إعادة",
                    Complaint = examination.Complaint,
                    Diagnosis =
                        examination.ExaminationDiagnosis.Select(examinationDiagnosi => examinationDiagnosi.Diagnosi)
                            .ToDiagnosisListString(),
                    PatientLength = examination.PatientLength.ToString(CultureInfo.CurrentCulture),
                    PatientWeight = examination.PatientWeight.ToString(CultureInfo.CurrentCulture),
                    PatientHeadCircumference = examination.PatientHeadCircumference.ToString(CultureInfo.CurrentCulture),
                    Treatment =
                        examination.ExaminationTreatments.Select(
                            examinationTreatments => examinationTreatments.Treatment).ToTreatmentsListString()
                });
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
            dtExaminationDate.Value = default(DateTime);
        }

        #endregion
    }
}