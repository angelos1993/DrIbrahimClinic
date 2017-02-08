using DrIbrahimClinic.DAL;

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

        #endregion
    }
}