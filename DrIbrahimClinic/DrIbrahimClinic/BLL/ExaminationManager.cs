using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.BLL
{
    public class ExaminationManager : BaseManager
    {
        #region Properties

        private ExaminationRepository _examinationRepository;

        public ExaminationRepository ExaminationRepository
            => _examinationRepository ?? (_examinationRepository = new ExaminationRepository());

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

        #endregion
    }
}