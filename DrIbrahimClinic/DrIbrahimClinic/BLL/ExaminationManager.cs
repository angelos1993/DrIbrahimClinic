using DrIbrahimClinic.DAL;

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

        #endregion
    }
}