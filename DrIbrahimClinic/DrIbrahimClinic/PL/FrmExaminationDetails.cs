using System;
using System.Globalization;
using System.Linq;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmExaminationDetails : FrmMaster
    {
        public FrmExaminationDetails(Examination examination)
        {
            InitializeComponent();
            _examination = examination;
        }

        #region Properties

        private readonly Examination _examination;

        #endregion

        #region Events

        private void FrmExaminationDetails_Load(object sender, EventArgs e)
        {
            var examinationType = _examination.ExaminationType == 1 ? "كشف" : "إعادة";
            lblExaminationTypeAndDate.Text = $"{examinationType} - {_examination.Date.ToFormattedArabicDate()}";
            lblPatientName.Text = _examination.Patient.Name;
            const string patientLnText = "<b>الطول</b>",
                patientWtText = "<b>الوزن</b>",
                patientHdCirText = "<b>محيط الرأس</b>";
            var patientLn =
                Math.Abs(_examination.PatientLength - (-1)) > 0
                    ? _examination.PatientLength.ToString(CultureInfo.CurrentCulture)
                    : "...";
            var patientWt =
                Math.Abs(_examination.PatientWeight - (-1)) > 0
                    ? _examination.PatientWeight.ToString(CultureInfo.CurrentCulture)
                    : "...";
            var patientHdCir =
                Math.Abs(_examination.PatientHeadCircumference - (-1)) > 0
                    ? _examination.PatientHeadCircumference.ToString(CultureInfo.CurrentCulture)
                    : "...";
            lblPatientLnWtHdCir.Text =
                $"{patientLnText}: {patientLn} \t --- \t {patientWtText}: {patientWt} \t --- \t {patientHdCirText}: {patientHdCir}";
            var examinationComplaint = string.IsNullOrEmpty(_examination.Complaint) ? "..." : _examination.Complaint;
            lblComplaint.Text = $"<b>Complaint:</b> {examinationComplaint}";
            var examinationDiagnosis =
                string.Join(", ", _examination.ExaminationDiagnosis.Select(
                    exDiagnosi => new DiagnosiVm {DiagnosiName = exDiagnosi.Diagnosi.Name})
                    .Select(diagnosi => diagnosi.DiagnosiName));
            examinationDiagnosis = string.IsNullOrEmpty(examinationDiagnosis) ? "..." : examinationDiagnosis;
            lblDiagnosis.Text =
                $"<b>Diagnosis:</b> {examinationDiagnosis}";
            dgvTreatments.DataSource =
                _examination.ExaminationTreatments.Select(examinationTreatments => new ExaminationTreatmentVm
                {
                    TreatmentName = examinationTreatments.Treatment.Name,
                    TreatmentDescription = examinationTreatments.Description
                }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}