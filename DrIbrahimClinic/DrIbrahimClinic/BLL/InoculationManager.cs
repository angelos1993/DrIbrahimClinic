using System;
using System.Collections.Generic;
using System.Linq;
using DrIbrahimClinic.DAL;
using DrIbrahimClinic.DAL.Model;

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

        public void AddInoculation(Inoculation inoculation)
        {
            InoculationRepository.Add(inoculation);
            InoculationRepository.Save();
        }

        public void UpdateInoculation(Inoculation inoculation)
        {
            InoculationRepository.Update(inoculation);
            InoculationRepository.Save();
        }

        public void DeleteInoculation(Inoculation inoculation)
        {
            InoculationRepository.Delete(inoculation);
            InoculationRepository.Save();
        }

        public IEnumerable<Inoculation> GetAllInoculations()
        {
            return InoculationRepository.GetAll().AsEnumerable();
        }

        public Inoculation GetInoculationById(int inoculationId)
        {
            return GetAllInoculations().FirstOrDefault(inoculation => inoculation.Id == inoculationId);
        }

        public IEnumerable<Inoculation> GetInoculations(Func<Inoculation, bool> where)
        {
            return GetAllInoculations().Where(where);
        }

        public Inoculation GetInoculationByNameAndPatientId(string inoculationName, int patientId)
        {
            return
                GetAllInoculations()
                    .FirstOrDefault(
                        inoculation => inoculation.Name == inoculationName && inoculation.PatientId == patientId);
        }

        #endregion
    }
}