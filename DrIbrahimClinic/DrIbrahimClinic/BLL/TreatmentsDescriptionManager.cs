using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrIbrahimClinic.BLL
{
    public class TreatmentsDescriptionManager : BaseManager
    {
        #region Properties

        private TreatmentsDescriptionRepository _treatmentsDescriptionRepository;

        private TreatmentsDescriptionRepository TreatmentsDescriptionRepository
            => _treatmentsDescriptionRepository ??
               (_treatmentsDescriptionRepository = new TreatmentsDescriptionRepository());

        #endregion

        #region Methods

        public IEnumerable<TreatmentsDescription> GetAllTreatmentsDescription()
        {
            return TreatmentsDescriptionRepository.GetAll().AsEnumerable();
        }

        public void AddTreatmentsDescription(TreatmentsDescription treatmentsDescription)
        {
            TreatmentsDescriptionRepository.Add(treatmentsDescription);
            TreatmentsDescriptionRepository.Save();
        }

        public bool IsTreatmentFoundByDescription(string description)
        {
            return
                GetAllTreatmentsDescription()
                    .Any(
                        treatmentsDescription =>
                            string.Equals(treatmentsDescription.Description, description,
                                StringComparison.CurrentCultureIgnoreCase));
        }

        #endregion
    }
}