using DrIbrahimClinic.DAL;

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

        #endregion
    }
}