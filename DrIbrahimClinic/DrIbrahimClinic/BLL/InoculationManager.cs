using DrIbrahimClinic.DAL;

namespace DrIbrahimClinic.BLL
{
    public class InoculationManager : BaseManager
    {
        #region Properties

        private InoculationRepository _inoculationRepository;

        public InoculationRepository InoculationRepository
            => _inoculationRepository ?? (_inoculationRepository = new InoculationRepository());

        #endregion

        #region Methods

        #endregion
    }
}