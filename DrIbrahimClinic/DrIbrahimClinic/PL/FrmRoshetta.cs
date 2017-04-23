using System;
using System.Collections.Generic;
using System.Globalization;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using Microsoft.Reporting.WinForms;

namespace DrIbrahimClinic.PL
{
    public partial class FrmRoshetta : MasterForm
    {
        public FrmRoshetta(Examination examination)
        {
            InitializeComponent();
            Examination = examination;
            RoshettaTreatmentVm = new List<RoshettaTreatmentVm>();
        }

        #region Properties

        private Examination Examination { get; }
        private List<RoshettaTreatmentVm> RoshettaTreatmentVm { get; }
        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());
        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());
        #endregion

        #region Events

        private void FrmRo4etta_Load(object sender, EventArgs e)
        {
            foreach (var treatment in Examination.ExaminationTreatments)
            {
                RoshettaTreatmentVm.Add(new RoshettaTreatmentVm
                {
                    R = @"R\",
                    TreatmentName = TreatmentManager.GetTreatmentNameByTreatmentId(treatment.TreatmentId),
                    TreatmentDescription = treatment.Description
                });
            }
            var patientWeight = Examination.PatientWeight.ToString(CultureInfo.CurrentCulture);
            if (patientWeight == "-1")
                patientWeight = string.Empty;
            rptViewerRoshetta.LocalReport.SetParameters(new[]
            {
                new ReportParameter("ExaminationDate", Examination.Date.ToShortDateString()),
                new ReportParameter("PatientAge",
                    (DateTime.Now.Year - PatientManager.GetPatientBirthdateByPatientId(Examination.PatientId).Year)
                        .ToString()),
                new ReportParameter("PatientId", Examination.PatientId.ToString()),
                new ReportParameter("PatientName", PatientManager.GetPatientNameByPatientId(Examination.PatientId)),
                new ReportParameter("PatientWeight", Examination.PatientWeight != -1 ? Examination.PatientWeight.ToString(CultureInfo.CurrentCulture) : "...")
            });
            RoshettaTreatmentVmBindingSource.DataSource = RoshettaTreatmentVm;
            rptViewerRoshetta.RefreshReport();
        }

        #endregion
    }
}