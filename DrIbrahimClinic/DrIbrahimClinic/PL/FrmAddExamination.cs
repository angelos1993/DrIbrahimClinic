using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;
using DrIbrahimClinic.Utility;
using static DrIbrahimClinic.Utility.MessageBoxUtility;
using static DrIbrahimClinic.Utility.Constants;
using DrIbrahimClinic.Properties;
using DrIbrahimClinic.Utility.Enums;
using static DrIbrahimClinic.Utility.Utility;
using static System.Math;
using static DrIbrahimClinic.Utility.InputLanguageUtility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmAddExamination : MasterForm
    {
        public FrmAddExamination()
        {
            InitializeComponent();
        }

        #region Properties

        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private IEnumerable<Patient> _patients;
        private IEnumerable<Patient> Patients => _patients ?? (_patients = PatientManager.GetAllPatients());

        private MedicalHistoryManager _medicalHistoryManager;

        private MedicalHistoryManager MedicalHistoryManager
            => _medicalHistoryManager ?? (_medicalHistoryManager = new MedicalHistoryManager());

        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        private InoculationManager _inoculationManager;

        private InoculationManager InoculationManager
            => _inoculationManager ?? (_inoculationManager = new InoculationManager());

        private DiagnosisManager _diagnosisManager;
        private DiagnosisManager DiagnosisManager => _diagnosisManager ?? (_diagnosisManager = new DiagnosisManager());

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());

        public Patient Patient { get; set; }

        public Examination Examination { get; set; }

        public AddExaminationFormMode Mode { get; set; }

        public List<DiagnosiVm> Diagnosis { get; set; } = new List<DiagnosiVm>();

        public List<ExaminationTreatmentVm> Treatments { get; set; } = new List<ExaminationTreatmentVm>();

        #endregion

        #region Events

        #region Form Load

        private void FrmAddExamination_Load(object sender, EventArgs e)
        {
            ClearForm();
            SetTextBoxesInputLanguages();
        }

        #endregion

        #region Patient

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (intInputPatientId.Value == 0 && string.IsNullOrEmpty(txtPatientName.Text))
            {
                ShowInfoMsg("يجب إدخال رقم المريض او اسم المريض");
                Cursor = Cursors.Default;
                return;
            }
            Patient = intInputPatientId.Value != 0
                ? PatientManager.GetPatientById(intInputPatientId.Value)
                : PatientManager.GetPatientByName(txtPatientName.Text);
            if (Patient != null)
                ShowPatientData(Patient);
            else
                ShowErrorMsg("لا يوجد مريض بهذا الرقم او الاسم");
            Cursor = Cursors.Default;
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (btnAddNewPatient.Text == @"جديد")
            {
                ClearPatientData();
                ShowOrHidePatientControls(AddExaminationFormMode.AddNew);
                btnAddNewPatient.Text = @"حفظ";
                btnAddNewPatient.Image = Resources.Save;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPatientName.Text.FullTrim()))
                {
                    txtPatientName.BackColor = ErrorColor;
                    Cursor = Cursors.Default;
                    return;
                }
                Patient = new Patient
                {
                    Name = txtPatientName.Text.FullTrim(),
                    Birthdate =
                        dtPatientBirthdate.Value != default(DateTime) ? dtPatientBirthdate.Value : (DateTime?) null,
                    Gender = switchBtnPatientGender.Value ? "M" : "F",
                    Phone = txtPatientPhone.Text.FullTrim(),
                    Address = txtPatientAddress.Text.FullTrim(),
                    BirthType = switchBtnPatientBirthType.Value ? (byte) 1 : (byte) 2,
                    SucklingType = switchBtnPatientSucklingType.Value ? (byte) 1 : (byte) 2
                };
                PatientManager.AddPatient(Patient);
                ShowInfoMsg($"تم إضافة المريض بنجاح\nرقم المريض هو: {Patient.Id}");
                ShowPatientData(Patient);
                btnAddNewPatient.Text = @"جديد";
                btnAddNewPatient.Image = Resources.Add;
            }
            Cursor = Cursors.Default;
        }

        private void btnEditPatientData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (btnEditPatientData.Text == @"تعديل")
            {
                ShowOrHidePatientControls(AddExaminationFormMode.Edit);
                btnEditPatientData.Text = @"حفظ";
                btnEditPatientData.Image = Resources.Save;
            }
            else
            {
                ShowOrHidePatientControls(AddExaminationFormMode.HasPatient);
                if (string.IsNullOrEmpty(txtPatientName.Text.FullTrim()))
                {
                    txtPatientName.BackColor = ErrorColor;
                    Cursor = Cursors.Default;
                    return;
                }
                Patient.Name = txtPatientName.Text.FullTrim();
                Patient.Birthdate = dtPatientBirthdate.Value != default(DateTime)
                    ? dtPatientBirthdate.Value
                    : (DateTime?) null;
                Patient.Gender = switchBtnPatientGender.Value ? "M" : "F";
                Patient.Phone = txtPatientPhone.Text.FullTrim();
                Patient.Address = txtPatientAddress.Text.FullTrim();
                Patient.BirthType = switchBtnPatientBirthType.Value ? (byte) 1 : (byte) 2;
                Patient.SucklingType = switchBtnPatientSucklingType.Value ? (byte) 1 : (byte) 2;
                PatientManager.UpdatePatient(Patient);
                btnEditPatientData.Text = @"تعديل";
                btnEditPatientData.Image = Resources.Edit;
            }
            Cursor = Cursors.Default;
        }

        private void btnClearPatientData_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearPatientPanel();
            Cursor = Cursors.Default;
        }

        #region Medical Histort Panel

        private void btnAddMedicalHistory_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtMedicalHistory.Text.FullTrim()))
            {
                txtMedicalHistory.BackColor = ErrorColor;
                Cursor = Cursors.Default;
                return;
            }
            var medicalHistory = new MedicalHistory
            {
                Description = txtMedicalHistory.Text.FullTrim(),
                PatientId = Patient.Id
            };
            MedicalHistoryManager.AddMedicalHistory(medicalHistory);
            Patient.MedicalHistories.Add(medicalHistory);
            ClearMedicalHistoryInputs();
            FillMedicalHistoryGrid();
            Cursor = Cursors.Default;
        }

        private void dgvMedicalHistory_DoubleClick(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف التاريخ المرضي المحدد؟") != DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            var medicalHistory =
                MedicalHistoryManager.GetMedicalHistoryByDescriptionAndPatientId(
                    dgvMedicalHistory.SelectedRows[0].Cells[0].Value.ToString(), Patient.Id);
            if (medicalHistory == null)
            {
                Cursor = Cursors.Default;
                return;
            }
            MedicalHistoryManager.DeleteMedicalHistory(medicalHistory);
            FillMedicalHistoryGrid();
            dgvMedicalHistory.Refresh();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Inoculations Panel
        
        private void btnAddInoculation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtInoculation.Text.FullTrim()))
            {
                txtInoculation.BackColor = ErrorColor;
                Cursor = Cursors.Default;
                return;
            }
            var inoculation = new Inoculation
            {
                Name = txtInoculation.Text.FullTrim(),
                Date = dtInoculationDate.Value != default(DateTime) ? dtInoculationDate.Value : (DateTime?) null,
                PatientId = Patient.Id
            };
            InoculationManager.AddInoculation(inoculation);
            Patient.Inoculations.Add(inoculation);
            ClearInoculationInputs();
            FillInoculationsGrid();
            Cursor = Cursors.Default;
        }

        private void dgvInoculations_DoubleClick(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف التطعيم المحدد؟") != DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            var inoculation =
                InoculationManager.GetInoculationByNameAndPatientId(
                    dgvInoculations.SelectedRows[0].Cells[0].Value.ToString(), Patient.Id);
            if (inoculation == null)
                return;
            InoculationManager.DeleteInoculation(inoculation);
            FillInoculationsGrid();
            Cursor = Cursors.Default;
        }

        #endregion

        #endregion

        #region Examination

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtDiagnosis.Text.FullTrim()))
            {
                txtDiagnosis.BackColor = ErrorColor;
                Cursor = Cursors.Default;
                return;
            }
            if (!DiagnosisManager.IsDiagnisiFound(txtDiagnosis.Text.FullTrim()))
                DiagnosisManager.AddDiagnosi(new Diagnosi { Name = txtDiagnosis.Text.FullTrim() });
            Diagnosis.Add(new DiagnosiVm { DiagnosiName = txtDiagnosis.Text.FullTrim() });
            ClearDiagnosisInputs();
            FillDiagnosisGrid();
            SetAutoCompletionForDiagnosisNames();
            Cursor = Cursors.Default;
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(txtTreatmentName.Text.FullTrim()))
            {
                txtTreatmentName.BackColor = ErrorColor;
                Cursor = Cursors.Default;
                return;
            }
            if (!TreatmentManager.IsTreatmentFoundByName(txtTreatmentName.Text.FullTrim()))
                TreatmentManager.AddTreatment(new Treatment {Name = txtTreatmentName.Text.FullTrim()});
            Treatments.Add(new ExaminationTreatmentVm
            {
                TreatmentName = txtTreatmentName.Text.FullTrim(),
                TreatmentDescription = txtTreatmentDescription.Text.FullTrim()
            });
            ClearTreatmentsInputs();
            FillTreatmentsGrid();
            SetAutoCompletionForTreatmentsNames();
            Cursor = Cursors.Default;
        }

        private void btnSaveExamination_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            double patientLengthTemp, patientWeightTemp, patientHeadCircumferenceTemp;
            Examination = new Examination
            {
                PatientId = Patient.Id,
                Date = DateTime.Now,
                ExaminationType = radK4f.Checked ? (byte) 1 : (byte) 2,
                Complaint = txtComplaint.Text.FullTrim(),
                PatientLength = double.TryParse(txtPatientLength.Text, out patientLengthTemp)
                    ? patientLengthTemp
                    : -1,
                PatientWeight = double.TryParse(txtPatientWeight.Text, out patientWeightTemp)
                    ? patientWeightTemp
                    : -1,
                PatientHeadCircumference = double.TryParse(txtPatientHeadCircumference.Text, out patientHeadCircumferenceTemp)
                    ? patientHeadCircumferenceTemp
                    : -1
            };
            ExaminationManager.AddExamination(Examination);
            if (Diagnosis.Any())
                ExaminationManager.AddDiagnosisToExamination(Examination, Diagnosis);
            if (Treatments.Any())
                ExaminationManager.AddTreatmentsToExamination(Examination, Treatments);
            btnSaveExamination.Enabled = false;
            btnPrintRoshetta.Enabled = true;
            pnlExaminationData.Enabled = true;
            pnlTreatment.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void btnClearExamination_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearExaminationPanel();
            Cursor = Cursors.Default;
        }

        private void btnPrintRoshetta_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmRoshetta(Examination).ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnNewExamination_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearForm();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDiagnosis_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Diagnosis.Remove(
                Diagnosis.FirstOrDefault(d => d.DiagnosiName == dgvDiagnosis.SelectedRows[0].Cells[0].Value.ToString()));
            FillDiagnosisGrid();
            Cursor = Cursors.Default;
        }

        private void dgvTreatments_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Treatments.Remove(
                Treatments.FirstOrDefault(
                    t => t.TreatmentName == dgvTreatments.SelectedRows[0].Cells[0].Value.ToString()));
            FillTreatmentsGrid();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Selected Tab Change...

        private void tabExamination_SelectedTabChanged(object sender,
            DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            switch (e.NewTab.Text)
            {
                case @"الزيارات السابقة":
                    if (Patient == null || Mode != AddExaminationFormMode.HasPatient)
                    {
                        Cursor = Cursors.Default;
                        ShowWarningMsg(@"يجب إدخال المريض أولاً");
                        e.NewTab.AttachedControl.Enabled = false;
                        return;
                    }
                    e.NewTab.AttachedControl.Enabled = true;
                    dgvPreviousVisits.DataSource = dgvPreviousVisits.DataSource ??
                                                   ExaminationManager.GetExaminationsByPatientId(Patient.Id)
                                                       .Select(examination => new ExaminationVm
                                                       {
                                                           PatientId = examination.PatientId,
                                                           PatientName = examination.Patient.Name,
                                                           ExaminationDate = examination.Date.ToFormattedArabicDate(),
                                                           ExaminationType =
                                                               examination.ExaminationType == 1 ? "كشف" : @"إعادة",
                                                           Complaint = examination.Complaint,
                                                           Diagnosis =
                                                               examination.ExaminationDiagnosis?.Select(
                                                                   examinationDiagnosis => examinationDiagnosis.Diagnosi)
                                                                   .ToDiagnosisListString(),
                                                           PatientLength =
                                                               Abs(examination.PatientLength - (-1)) > 0
                                                                   ? examination.PatientLength.ToString(
                                                                       CultureInfo.CurrentCulture)
                                                                   : string.Empty,
                                                           PatientWeight =
                                                               Abs(examination.PatientWeight - (-1)) > 0
                                                                   ? examination.PatientWeight.ToString(
                                                                       CultureInfo.CurrentCulture)
                                                                   : string.Empty,
                                                           PatientHeadCircumference =
                                                               Abs(examination.PatientHeadCircumference - (-1)) > 0
                                                                   ? examination.PatientHeadCircumference.ToString(
                                                                       CultureInfo.CurrentCulture)
                                                                   : string.Empty,
                                                           Treatment =
                                                               examination.ExaminationTreatments?.Select(
                                                                   examinationTreatments =>
                                                                       examinationTreatments.Treatment)
                                                                   .ToTreatmentsListString()
                                                       }).ToList();
                    break;
                case @"الكشف":
                    if (Patient == null || Mode != AddExaminationFormMode.HasPatient)
                    {
                        Cursor = Cursors.Default;
                        ShowWarningMsg(@"يجب إدخال المريض أولاً");
                        e.NewTab.AttachedControl.Enabled = false;
                        return;
                    }
                    e.NewTab.AttachedControl.Enabled = true;
                    SetAutoCompletionForDiagnosisNames();
                    SetAutoCompletionForTreatmentsNames();
                    break;
            }
            Cursor = Cursors.Default;
        }

        #endregion

        #endregion

        #region Methods

        private void ClearForm()
        {
            tabExamination.SelectedTabIndex = 0;
            ClearPatientPanel();
            ClearPreviousVisitsDgv();
            ClearExaminationPanel();
            SetAutoCompletionForPatientsNames();
            ClearPropertiesValues();
        }

        private void ClearPropertiesValues()
        {
            Patient = null;
            Examination = null;
            Mode = AddExaminationFormMode.Normal;
            Diagnosis = new List<DiagnosiVm>();
            Treatments = new List<ExaminationTreatmentVm>();
        }

        private void ClearPatientPanel()
        {
            ShowOrHidePatientControls(AddExaminationFormMode.Normal);
            btnAddNewPatient.Text = @"جديد";
            btnAddNewPatient.Image = Resources.Add;
            txtPatientName.BackColor = Color.Empty;
            ClearPatientData();
        }

        private void ClearPatientData()
        {
            intInputPatientId.Value = 0;
            txtPatientName.Text = string.Empty;
            dtPatientBirthdate.Value = default(DateTime);
            switchBtnPatientGender.Value = true;
            txtPatientPhone.Text = string.Empty;
            txtPatientAddress.Text = string.Empty;
            switchBtnPatientBirthType.Value = true;
            switchBtnPatientSucklingType.Value = true;
            ClearMedicalHistoryInputs();
            dgvMedicalHistory.DataSource = null;
            ClearInoculationInputs();
            dgvInoculations.DataSource = null;
        }

        private void ClearMedicalHistoryInputs()
        {
            txtMedicalHistory.Text = string.Empty;
            txtMedicalHistory.BackColor = Color.Empty;
        }

        private void ClearInoculationInputs()
        {
            txtInoculation.Text = string.Empty;
            txtInoculation.BackColor = Color.Empty;
            dtInoculationDate.Value = default(DateTime);
        }

        private void ShowOrHidePatientControls(AddExaminationFormMode mode)
        {
            Mode = mode;
            intInputPatientId.Enabled = mode == AddExaminationFormMode.Normal;
            txtPatientName.Enabled = mode == AddExaminationFormMode.Normal || mode == AddExaminationFormMode.AddNew ||
                                     mode == AddExaminationFormMode.Edit;
            btnFindPatient.Enabled = mode == AddExaminationFormMode.Normal;
            dtPatientBirthdate.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            switchBtnPatientGender.Enabled = mode == AddExaminationFormMode.AddNew ||
                                             mode == AddExaminationFormMode.Edit;
            txtPatientPhone.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            txtPatientAddress.Enabled = mode == AddExaminationFormMode.AddNew || mode == AddExaminationFormMode.Edit;
            switchBtnPatientBirthType.Enabled = mode == AddExaminationFormMode.AddNew ||
                                                mode == AddExaminationFormMode.Edit;
            switchBtnPatientSucklingType.Enabled = mode == AddExaminationFormMode.AddNew ||
                                                   mode == AddExaminationFormMode.Edit;
            grpPanelMedicalHistory.Enabled = mode == AddExaminationFormMode.Edit ||
                                             mode == AddExaminationFormMode.HasPatient;
            grpPanelInoculations.Enabled = mode == AddExaminationFormMode.Edit ||
                                           mode == AddExaminationFormMode.HasPatient;
            btnAddNewPatient.Enabled = mode == AddExaminationFormMode.Normal ||
                                       mode == AddExaminationFormMode.HasPatient ||
                                       mode == AddExaminationFormMode.AddNew;
            btnEditPatientData.Enabled = mode == AddExaminationFormMode.Edit ||
                                         mode == AddExaminationFormMode.HasPatient;
        }

        private void ShowPatientData(Patient patient)
        {
            ShowOrHidePatientControls(AddExaminationFormMode.HasPatient);
            intInputPatientId.Value = patient.Id;
            txtPatientName.Text = patient.Name;
            dtPatientBirthdate.Value = patient.Birthdate ?? default(DateTime);
            switchBtnPatientGender.Value = patient.Gender == "M";
            txtPatientPhone.Text = patient.Phone ?? string.Empty;
            txtPatientAddress.Text = patient.Address ?? string.Empty;
            switchBtnPatientBirthType.Value = patient.BirthType == 1;
            switchBtnPatientSucklingType.Value = patient.SucklingType == 1;
            FillMedicalHistoryGrid();
            FillInoculationsGrid();
        }

        private void SetAutoCompletionForPatientsNames()
        {
            var namesCollection = new AutoCompleteStringCollection();
            namesCollection.AddRange(Patients.Select(p => p.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtPatientName, namesCollection);
        }

        private void FillMedicalHistoryGrid()
        {
            dgvMedicalHistory.DataSource =
                MedicalHistoryManager.GetMedicalHistorys(medicalHistory => medicalHistory.PatientId == Patient.Id)
                    .Select(medicalHistory => new MedicalHistoryVm
                    {
                        Description = medicalHistory.Description
                    }).ToList();
        }

        private void FillInoculationsGrid()
        {
            dgvInoculations.DataSource =
                InoculationManager.GetInoculations(inoculation => inoculation.PatientId == Patient.Id)
                    .Select(inoculation => new InoculationVm
                    {
                        Name = inoculation.Name,
                        Date = inoculation.Date?.ToFormattedArabicDate()
                    }).ToList();
        }

        private void ClearPreviousVisitsDgv()
        {
            dgvPreviousVisits.DataSource = null;
            dgvPreviousVisits.Refresh();
        }

        private void ClearExaminationPanel()
        {
            radK4f.Checked = true;
            txtPatientLength.Text = string.Empty;
            txtPatientWeight.Text = string.Empty;
            txtPatientHeadCircumference.Text = string.Empty;
            txtComplaint.Text = string.Empty;
            txtDiagnosis.Text = string.Empty;
            dgvDiagnosis.DataSource = null;
            txtTreatmentName.Text = string.Empty;
            txtTreatmentDescription.Text = string.Empty;
            dgvTreatments.DataSource = null;
            btnSaveExamination.Enabled = true;
            btnPrintRoshetta.Enabled = false;
            pnlExaminationData.Enabled = true;
            pnlTreatment.Enabled = true;
        }

        private void FillDiagnosisGrid()
        {
            dgvDiagnosis.DataSource = null;
            dgvDiagnosis.DataSource = Diagnosis;
        }

        private void FillTreatmentsGrid()
        {
            dgvTreatments.DataSource = null;
            dgvTreatments.DataSource = Treatments;
        }

        private void ClearDiagnosisInputs()
        {
            txtDiagnosis.Text = string.Empty;
            txtDiagnosis.BackColor = Color.Empty;
        }

        private void ClearTreatmentsInputs()
        {
            txtTreatmentName.Text = string.Empty;
            txtTreatmentDescription.Text = string.Empty;
            txtTreatmentName.BackColor = Color.Empty;
        }

        private void SetAutoCompletionForTreatmentsNames()
        {
            var namesCollection = new AutoCompleteStringCollection();
            namesCollection.AddRange(TreatmentManager.GetAllTreatments().Select(t => t.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtTreatmentName, namesCollection);
        }

        private void SetAutoCompletionForDiagnosisNames()
        {
            var namesCollection = new AutoCompleteStringCollection();
            namesCollection.AddRange(DiagnosisManager.GetAllDiagnosis().Select(d => d.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtDiagnosis, namesCollection);
        }

        private void SetTextBoxesInputLanguages()
        {
            #region Patient Tab

            txtPatientName.GotFocus += SetArabicInputLanguage;
            txtPatientPhone.GotFocus += SetArabicInputLanguage;
            txtPatientAddress.GotFocus += SetArabicInputLanguage;
            txtInoculation.GotFocus += SetEnglishInputLanguage;
            txtMedicalHistory.GotFocus += SetEnglishInputLanguage;

            #endregion

            #region Examination Tab

            txtPatientLength.GotFocus += SetArabicInputLanguage;
            txtPatientWeight.GotFocus += SetArabicInputLanguage;
            txtPatientHeadCircumference.GotFocus += SetArabicInputLanguage;
            txtComplaint.GotFocus += SetEnglishInputLanguage;
            txtDiagnosis.GotFocus += SetEnglishInputLanguage;
            txtTreatmentName.GotFocus += SetEnglishInputLanguage;
            txtTreatmentDescription.GotFocus += SetArabicInputLanguage;

            #endregion
        }

        #endregion
    }
}