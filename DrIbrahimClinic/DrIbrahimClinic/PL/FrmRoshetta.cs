using System;
using System.Globalization;
using System.Linq;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static System.Math;

namespace DrIbrahimClinic.PL
{
    public partial class FrmRoshetta : MasterForm
    {
        public FrmRoshetta(Examination examination)
        {
            InitializeComponent();
            RoshettaVm = new RoshettaVm
            {
                PatientId = examination.PatientId.ToString(),
                PatientName = examination.Patient.Name,
                PatientWeight =
                    Abs(examination.PatientWeight - (-1)) > 0
                        ? examination.PatientWeight.ToString(CultureInfo.CurrentCulture)
                        : string.Empty,
                ExaminationDate = examination.Date.ToShortDateString(),
                PatientAge = examination.Patient.Birthdate.ToAgeFromBirthdate(),
                RoshettaTreatments =
                    examination.ExaminationTreatments.Select(examinationTreatment => new RoshettaTreatmentVm
                    {
                        R = "R",
                        TreatmentName = TreatmentManager.GetTreatmentById(examinationTreatment.TreatmentId).Name,
                        TreatmentDescription = examinationTreatment.Description
                    }).ToList()
            };
        }

        #region Properties

        public RoshettaVm RoshettaVm { get; set; }

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());

        #endregion

        private void FrmRo4etta_Load(object sender, EventArgs e)
        {
            rptViewerRoshetta.RefreshReport();
        }
    }
}