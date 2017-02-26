using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.BLL
{
    public class TreatmentManager : BaseManager
    {
        #region Properties

        private TreatmentRepository _treatmentRepository;

        public TreatmentRepository TreatmentRepository
            => _treatmentRepository ?? (_treatmentRepository = new TreatmentRepository());

        #endregion

        #region Methods

        public void AddTreatment(Treatment treatment)
        {
            TreatmentRepository.Add(treatment);
            TreatmentRepository.Save();
        }

        public void UpdateTreatment(Treatment treatment)
        {
            TreatmentRepository.Update(treatment);
            TreatmentRepository.Save();
        }

        public void DeleteTreatment(Treatment treatment)
        {
            TreatmentRepository.Delete(treatment);
            TreatmentRepository.Save();
        }

        public IEnumerable<Treatment> GetAllTreatments()
        {
            return TreatmentRepository.GetAll().AsEnumerable();
        }

        public Treatment GetTreatmentById(int treatmentId)
        {
            return GetAllTreatments().FirstOrDefault(treatment => treatment.Id == treatmentId);
        }

        public Treatment GeTreatmentByName(string treatmentName)
        {
            return
                GetAllTreatments()
                    .FirstOrDefault(
                        treatment =>
                            string.Equals(treatment.Name, treatmentName, StringComparison.CurrentCultureIgnoreCase));
        }

        public IEnumerable<Treatment> GetTreatments(Func<Treatment, bool> where)
        {
            return GetAllTreatments().Where(where);
        }

        public bool IsTreatmentFound(string treatmentName)
        {
            return GetAllTreatments().Any(tr => tr.Name == treatmentName);
        }

        public int GetTreatmentIdByTreatmentName(string treatmentName)
        {
            return GetAllTreatments().FirstOrDefault(treatment => treatment.Name == treatmentName)?.Id ?? -1;
        }

        public string GetTreatmentNameByTreatmentId(int treatmentId)
        {
            return GetAllTreatments().FirstOrDefault(treatment => treatment.Id == treatmentId)?.Name ?? string.Empty;
        }

        #endregion
    }
}