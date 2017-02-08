using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.BLL
{
    public class DiagnosisManager : BaseManager
    {
        #region Properties

        private DiagnosisRepository _diagnosisRepository;

        public DiagnosisRepository DiagnosisRepository
            => _diagnosisRepository ?? (_diagnosisRepository = new DiagnosisRepository());

        #endregion

        #region Methods

        public void AddDiagnosi(Diagnosi diagnosi)
        {
            DiagnosisRepository.Add(diagnosi);
            DiagnosisRepository.Save();
        }

        public void UpdateDiagnosi(Diagnosi diagnosi)
        {
            DiagnosisRepository.Update(diagnosi);
            DiagnosisRepository.Save();
        }

        public void DeleteDiagnosi(Diagnosi diagnosi)
        {
            DiagnosisRepository.Delete(diagnosi);
            DiagnosisRepository.Save();
        }

        public IEnumerable<Diagnosi> GetAllDiagnosis()
        {
            return DiagnosisRepository.GetAll().AsEnumerable();
        }

        public Diagnosi GetDiagnosiById(int diagnosiId)
        {
            return GetAllDiagnosis().FirstOrDefault(diagnosi => diagnosi.Id == diagnosiId);
        }

        public IEnumerable<Diagnosi> GetDiagnosis(Func<Diagnosi, bool> where)
        {
            return GetAllDiagnosis().Where(where);
        }

        #endregion
    }
}