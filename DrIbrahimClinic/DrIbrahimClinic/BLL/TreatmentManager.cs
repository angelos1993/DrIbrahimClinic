using DrIbrahimClinic.DAL;

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

        #endregion
    }
}