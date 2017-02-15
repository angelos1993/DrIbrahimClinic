using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.BLL
{
    public class MedicalHistoryManager : BaseManager
    {
        #region Properties

        private MedicalHistoryRepository _medicalHistoryRepository;

        public MedicalHistoryRepository MedicalHistoryRepository
            => _medicalHistoryRepository ?? (_medicalHistoryRepository = new MedicalHistoryRepository());

        #endregion

        #region Methods

        public void AddMedicalHistory(MedicalHistory medicalHistory)
        {
            MedicalHistoryRepository.Add(medicalHistory);
            MedicalHistoryRepository.Save();
        }

        public void UpdateMedicalHistory(MedicalHistory medicalHistory)
        {
            MedicalHistoryRepository.Update(medicalHistory);
            MedicalHistoryRepository.Save();
        }

        public void DeleteMedicalHistory(MedicalHistory medicalHistory)
        {
            MedicalHistoryRepository.Delete(medicalHistory);
            MedicalHistoryRepository.Save();
        }

        public IEnumerable<MedicalHistory> GetAllMedicalHistorys()
        {
            return MedicalHistoryRepository.GetAll().AsEnumerable();
        }

        public MedicalHistory GetMedicalHistoryById(int medicalHistoryId)
        {
            return GetAllMedicalHistorys().FirstOrDefault(medicalHistory => medicalHistory.Id == medicalHistoryId);
        }

        public IEnumerable<MedicalHistory> GetMedicalHistorys(Func<MedicalHistory, bool> where)
        {
            return GetAllMedicalHistorys().Where(where);
        }

        public IEnumerable<MedicalHistory> GetMedicalHistorysByPatientId(int patientId)
        {
            return GetMedicalHistorys(medicalHistory => medicalHistory.PatientId == patientId);
        }

        public MedicalHistory GetMedicalHistoryByDescriptionAndPatientId(string description, int patientId)
        {
            return
                GetAllMedicalHistorys()
                    .FirstOrDefault(
                        medicalHistory =>
                            medicalHistory.Description == description && medicalHistory.PatientId == patientId);
        }

        #endregion
    }
}