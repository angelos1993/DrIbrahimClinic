using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;
using DrIbrahimClinic.DAL.VMs;

namespace DrIbrahimClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        private ExaminationRepository _examinationRepository;

        private ExaminationRepository ExaminationRepository
            => _examinationRepository ?? (_examinationRepository = new ExaminationRepository());

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());
        #endregion

        #region Methods

        public void AddExamination(Examination examination)
        {
            ExaminationRepository.Add(examination);
            ExaminationRepository.Save();
        }

        public void UpdateExamination(Examination examination)
        {
            ExaminationRepository.Update(examination);
            ExaminationRepository.Save();
        }

        public void DeleteExamination(Examination examination)
        {
            ExaminationRepository.Delete(examination);
            ExaminationRepository.Save();
        }

        public IEnumerable<Examination> GetAllExaminations()
        {
            return ExaminationRepository.GetAll().AsEnumerable();
        }

        public Examination GetExaminationById(int examinationId)
        {
            return GetAllExaminations().FirstOrDefault(examination => examination.Id == examinationId);
        }

        public IEnumerable<Examination> GetExaminations(Func<Examination, bool> where)
        {
            return GetAllExaminations().Where(where);
        }

        public IEnumerable<Examination> GetExaminationsByPatientId(int patientId)
        {
            return GetExaminations(examination => examination.PatientId == patientId);
        }

        public void AddDiagnosisToExamination(Examination examination, List<Diagnosi> diagnosis)
        {
            foreach (var diagnosi in diagnosis)
                examination.ExaminationDiagnosis.Add(new ExaminationDiagnosi
                {
                    DisgnosisId = diagnosi.Id,
                    ExaminationId = examination.Id
                });
            UpdateExamination(examination);
        }

        public void AddTreatmentsToExamination(Examination examination, List<ExaminationTreatmentVm> treatments)
        {
            foreach (var treatment in treatments)
                examination.ExaminationTreatments.Add(new ExaminationTreatment
                {

                    TreatmentId = TreatmentManager.GetTreatmentIdByTreatmentName(treatment.TreatmentName),
                    ExaminationId = examination.Id,
                    Description = treatment.TreatmentDescription
                });
            UpdateExamination(examination);
        }

        #endregion
    }
}